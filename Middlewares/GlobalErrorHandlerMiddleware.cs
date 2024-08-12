using ExaminationSystem.Exceptions;
using ExaminationSystem.ViewModels;
using System.Diagnostics;

namespace ExaminationSystem.Middlewares
{
    public class GlobalErrorHandlerMiddleware
    {
        RequestDelegate _next;

        public GlobalErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {

               await _next(context);
            }
            catch (Exception ex)
            {

                string message = "Error Occured";
                ErrorCodes errorCodes = ErrorCodes.UnKnown;

                if (ex is BusinessException businessException) {
                
                    message = businessException.Message;
                    errorCodes = businessException.ErrorCodes;
                }
                else
                {
                    File.WriteAllText("C:\\Log.txt", $"Error happend:{ex.Message}");
                }
                var resultViewModel = ResultViewModel<bool>.Failure(errorCodes,message);
                
                await context.Response.WriteAsJsonAsync(resultViewModel);
            }
        }
    }
}

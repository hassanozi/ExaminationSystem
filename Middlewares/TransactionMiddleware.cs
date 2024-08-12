using ExaminationSystem.Data;

namespace ExaminationSystem.Middlewares
{
    public class TransactionMiddleware
    {
        RequestDelegate _next;
        Context _context;

        public TransactionMiddleware(RequestDelegate next, Context context)
        {
            _next = next;
            _context = context;
        }

        public async Task InvokeAsync(HttpContext httpcontext)
        {

            var method = httpcontext.Request.Method.ToUpper();

            if (method == "POST" || method == "PUT" || method == "DELETE")
            {

                var transaction = _context.Database.BeginTransaction();
                try
                {
                    await _next(httpcontext);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    File.WriteAllText("C:\\Log.txt", "Error happend");
                    transaction?.Rollback();

                    throw;
                }
            }
            else
            {
                await _next(httpcontext);
            }

        }
    }
}

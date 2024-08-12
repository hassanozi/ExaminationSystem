using ExaminationSystem.Exceptions;

namespace ExaminationSystem.ViewModels
{
    public class ResultViewModel<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
        public ErrorCodes ErrorCodes { get; set; }


        public static ResultViewModel<T> Success<T> (T data, string message ="")
        {
            return new ResultViewModel<T>
            {
                IsSuccess = true,
                Data = data,
                Message = message,
                ErrorCodes = ErrorCodes.None
            };
        }

        public static ResultViewModel<T> Failure(ErrorCodes errorCodes, string message = "")
        {
            return new ResultViewModel<T>
            {
                IsSuccess = false,
                Data = default,
                Message = message,
                ErrorCodes = errorCodes
            };
        }
    }
}

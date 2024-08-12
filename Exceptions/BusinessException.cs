namespace ExaminationSystem.Exceptions
{
    public class BusinessException : Exception
    {
        public ErrorCodes ErrorCodes { get; set; }
        public BusinessException(ErrorCodes errorCodes, string message) : base(message) { 
        
        }
    }
}

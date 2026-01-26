namespace AuthServiceIN6BM.Application.Exceptions;


public class BussinessException : Exception
{
    public string ErrorCode { get; }

    public BussinessException(string errorCode, string message) : base(message)
    {
        ErrorCode = errorCode;
    }


    public BussinessException(string errorCode, string message, Exception innerException) : base(message, innerException)
    {
        ErrorCode = errorCode;
    }
}
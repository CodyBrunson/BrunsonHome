namespace BrunsonHome.Shared.Exceptions;

public class NoTrimsFoundException : Exception
{
    public NoTrimsFoundException() : base()
    {
    }

    public NoTrimsFoundException(string message) : base(message)
    {
    }

    public NoTrimsFoundException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
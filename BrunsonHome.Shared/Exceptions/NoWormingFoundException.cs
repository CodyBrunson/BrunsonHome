namespace BrunsonHome.Shared.Exceptions;

public class NoWormingFoundException : Exception
{
    public NoWormingFoundException() : base()
    {
    }

    public NoWormingFoundException(string message) : base(message)
    {
    }

    public NoWormingFoundException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
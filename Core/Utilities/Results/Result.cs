namespace Core.Utilities.Results;

public class Result : IResult
{
    protected Result(bool success)
    {
    }

    protected Result(bool success, string message) : this(success)
    {
        Message = message;
    }

    public bool Success { get; }
    public string Message { get; }
}
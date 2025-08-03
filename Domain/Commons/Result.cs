
namespace Domain.Commons;

public class Result(Error error)
{
    public Error Error { get; set; } = error;
    public bool IsSuccess => error == Error.None;

    public static Result Success() => new(Error.None);
    public static Result<T> Success<T>(T value) => new(value, Error.None);
    public static Result Failure(Error error) => new(error);
    public static Result<T> Failure<T>(Error error) => new(default!, error);
}

public class Result<T>(T value, Error error) : Result(error) 
{
    private readonly T _value = value;

    public T Value => IsSuccess
       ? _value
       : throw new InvalidOperationException("Cannot access value from a failed result.");
}
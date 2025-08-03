namespace Domain.Commons;

public class Error(string description, ErrorType error)
{
    public string Description { get; } = description;
    public ErrorType Type { get; } = error;

    public static readonly Error None = new(string.Empty, ErrorType.None);

    public static Error Validation(string description) =>
     new(description, ErrorType.Validation);

    public static Error BadRequest(string description) =>
        new(description, ErrorType.BadRequest);

    public static Error NotFound(string description) =>
        new(description, ErrorType.NotFound);

    public static Error Conflict(string description) =>
        new(description, ErrorType.Conflict);
    public static Error Problem(string description) =>
      new(description, ErrorType.Problem);
    public static Error Unauthorized(string description) =>
        new(description, ErrorType.Unauthorized);

    public static Error Forbidden(string description) =>
        new(description, ErrorType.Forbidden);
}
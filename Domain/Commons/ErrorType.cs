namespace Domain.Commons;

public enum ErrorType
{
    None = 0,
    Validation = 1,
    BadRequest = 2,
    NotFound = 3,
    Conflict = 4,
    Unauthorized = 5,
    Forbidden = 6,
    Problem = 7
}

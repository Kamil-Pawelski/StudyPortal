namespace Application.Abstractions.Database;

public interface IApplicationContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

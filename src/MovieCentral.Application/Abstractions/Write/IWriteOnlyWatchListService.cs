namespace MovieCentral.Application.Abstractions.Write;

public interface IWriteOnlyWatchListService
{
    Task AddAsync(Guid userId, Guid movieId, CancellationToken cancellationToken = default);
    Task RemoveAsync(Guid userId, Guid movieId, CancellationToken cancellationToken = default);
}

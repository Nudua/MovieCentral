using MovieCentral.Shared.Dtos.WatchList;

namespace MovieCentral.Application.Abstractions.Read;

public interface IReadOnlyWatchListService
{
    Task<IEnumerable<WatchListItemDto>> GetAsync(Guid userId, CancellationToken cancellationToken = default);
}

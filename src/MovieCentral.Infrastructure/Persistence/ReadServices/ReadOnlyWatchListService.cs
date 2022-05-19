using Microsoft.EntityFrameworkCore;
using MovieCentral.Application.Abstractions;
using MovieCentral.Application.Abstractions.Read;
using MovieCentral.Shared.Dtos.WatchList;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Infrastructure.Persistence.ReadServices;

public class ReadOnlyWatchListService : IReadOnlyWatchListService
{
    private readonly IApplicationDbContext _dbContext;

    public ReadOnlyWatchListService(IApplicationDbContext dbContext) => _dbContext = Guard.ThrowIfNull(dbContext);

    public async Task<IEnumerable<WatchListItemDto>> GetAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        return await _dbContext.WatchListItems
            .Where(x => x.UserFK == userId)
            .OrderBy(x => x.Added)
            .Select(x => new WatchListItemDto
            {
                MovieId = x.MovieFK,
                Title = x.Movie.Title,
                CoverUrl = x.Movie.CoverUrl,
                Added = x.Added,
                Genre = x.Movie.Genre,
                Ranking = x.Movie.Ranking
            }).ToListAsync(cancellationToken);
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieCentral.Application.Abstractions;
using MovieCentral.Application.Abstractions.Write;
using MovieCentral.Application.Exceptions;
using MovieCentral.Domain.Entities;
using MovieCentral.Infrastructure.Persistence.ReadServices;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Infrastructure.Persistence.WriteServices;

public class WriteOnlyWatchListService : IWriteOnlyWatchListService
{
    private readonly IApplicationDbContext _dbContext;
    private readonly ILogger<ReadOnlyUsersService> _logger;

    public WriteOnlyWatchListService(IApplicationDbContext dbContext, ILogger<ReadOnlyUsersService> logger)
    {
        _dbContext = Guard.ThrowIfNull(dbContext);
        _logger = Guard.ThrowIfNull(logger);
    }

    public async Task RemoveAsync(Guid userId, Guid movieId, CancellationToken cancellationToken = default)
    {
        var watchListMovie = await _dbContext.WatchListItems.FirstOrDefaultAsync(
            x => x.UserFK == userId &&
            x.MovieFK == movieId,
            cancellationToken);

        if (watchListMovie is null)
        {
            _logger.LogWarning("Tried to remove non-existant movie from watchlist. UserId = {UserId} and MovieId = {MovieId}", userId, movieId);
            throw new NotFoundException($"Movie with Id = {movieId} was not found in the watchlist.");
        }

        _dbContext.WatchListItems.Remove(watchListMovie);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task AddAsync(Guid userId, Guid movieId, CancellationToken cancellationToken = default)
    {
        var user = await _dbContext.Users.FindAsync(new object[] { userId }, cancellationToken);

        if (user is null)
        {
            _logger.LogWarning("Unable to get user profile with Guid = {Id}", userId);
            throw new NotFoundException($"User with Id = {userId} was not found.");
        }

        var movieExists = await _dbContext.Movies.AnyAsync(x => x.Id == movieId, cancellationToken);

        if (!movieExists)
        {
            _logger.LogWarning("Tried to add non-existant movie to watchlist UserId = {UserId} and MovieId = {MovieId}", userId, movieId);
            throw new NotFoundException($"Movie with Id = {movieId} does not exist.");
        }

        var isAlreadyInWatchList = await _dbContext.WatchListItems.AnyAsync(x => x.UserFK == userId && x.MovieFK == movieId, cancellationToken);

        if (isAlreadyInWatchList)
        {
            _logger.LogWarning("Movie already exists in watchlist. UserId = {UserId} MovieId = {MovieId}", userId, movieId);
            return;
        }

        _dbContext.WatchListItems.Add(new WatchListItem { Added = DateTime.UtcNow, UserFK = userId, MovieFK = movieId });
        await _dbContext.SaveChangesAsync(cancellationToken);
        _logger.LogInformation("Added Movie with Id = {MovieId} to User with Id = {UserId}", movieId, userId);
    }
}

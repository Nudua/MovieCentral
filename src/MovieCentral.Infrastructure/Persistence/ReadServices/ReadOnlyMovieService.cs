using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieCentral.Application.Abstractions;
using MovieCentral.Application.Abstractions.Read;
using MovieCentral.Application.Exceptions;
using MovieCentral.Application.Pagination;
using MovieCentral.Domain.Entities;
using MovieCentral.Shared.Constants;
using MovieCentral.Shared.Dtos.Movie;
using MovieCentral.Shared.Dtos.Parameters;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Infrastructure.Persistence.ReadServices;

public class ReadOnlyMovieService : IReadOnlyMovieService
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ILogger<ReadOnlyUsersService> _logger;

    public ReadOnlyMovieService(IApplicationDbContext dbContext, IMapper mapper, ILogger<ReadOnlyUsersService> logger)
    {
        _dbContext = Guard.ThrowIfNull(dbContext);
        _mapper = Guard.ThrowIfNull(mapper);
        _logger = Guard.ThrowIfNull(logger);
    }

    public async Task<PagedList<MovieSimpleDto>> GetPagedListAsync(PagedMovieListParameters parameters, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Fetching movies with Page = {Page} and PageSize = {PageSize}", parameters.PageNumber, parameters.PageSize);

        IQueryable<Movie> query = _dbContext.Movies
                                            .AsNoTracking()
                                            .OrderBy(x => x.Ranking);

        if (parameters.Genre is not Genre.None)
        {
            query = query.Where(x => x.Genre == parameters.Genre);
        }

        return await PagedList<Movie>.CreateAndProjectToAsync<MovieSimpleDto>(query,
                                                                              parameters.PageNumber,
                                                                              parameters.PageSize,
                                                                              _mapper,
                                                                              cancellationToken);
    }

    public async Task<MovieDetailedDto> GetAsync(Guid id, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Fetching Movie with Id = {Id}", id);

        var movie = await _dbContext.Movies.AsNoTracking()
                                           .Where(x => x.Id == id)
                                           .ProjectTo<MovieDetailedDto>(_mapper.ConfigurationProvider)
                                           .FirstOrDefaultAsync(cancellationToken);

        if (movie is null)
        {
            _logger.LogWarning("Movie with Id = {MovieId} was not found.", id);
            throw new NotFoundException($"Movie with Id = {id} was not found.");
        }

        return movie;
    }
}

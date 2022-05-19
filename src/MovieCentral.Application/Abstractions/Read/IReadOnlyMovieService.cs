using MovieCentral.Application.Pagination;
using MovieCentral.Shared.Dtos.Movie;
using MovieCentral.Shared.Dtos.Parameters;

namespace MovieCentral.Application.Abstractions.Read;

public interface IReadOnlyMovieService
{
    Task<MovieDetailedDto> GetAsync(Guid id, CancellationToken cancellationToken = default);
    Task<PagedList<MovieSimpleDto>> GetPagedListAsync(PagedMovieListParameters parameters, CancellationToken cancellationToken = default);
}

using MovieCentral.Shared.Constants;

namespace MovieCentral.Shared.Dtos.Parameters;

public record PagedMovieListParameters(int PageNumber, int PageSize, Genre Genre = Genre.None)
{
    public const int MaxPageSize = 20;
}

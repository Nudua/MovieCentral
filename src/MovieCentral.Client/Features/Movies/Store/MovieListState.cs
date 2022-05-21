using Fluxor;
using MovieCentral.Client.Features.Movies.Store.Effects;
using MovieCentral.Client.Features.Shared;
using MovieCentral.Shared.Constants;

namespace MovieCentral.Client.Features.Movies.Store;

[FeatureState]
public record MovieListState(
        FetchState FetchState,
        int CurrentPage,
        int PageSize,
        int TotalCount,
        int TotalPages,
        Genre Genre,
        List<MovieSimpleDtoExtended> Movies,
        string ErrorMessage)
{
    private MovieListState() : this(FetchState.None, 1, 10, 0, 1, Genre.None, null, null) { }
}

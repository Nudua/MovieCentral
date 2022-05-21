using Fluxor;
using MovieCentral.Client.Features.Shared;
using MovieCentral.Shared.Dtos.Movie;

namespace MovieCentral.Client.Features.MovieDetails.Store;

[FeatureState]
public record MovieState(FetchState FetchState, MovieDetailedDto Movie, string ErrorMessage)
{
    private MovieState() : this(FetchState.None, null, null) { }
}

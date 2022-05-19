using Fluxor;
using MovieCentral.Shared.Dtos.Movie;

namespace MovieCentral.Client.Store.State;

[FeatureState]
public record MovieState(FetchState FetchState, MovieDetailedDto Movie, string ErrorMessage)
{
    private MovieState() : this(FetchState.None, null, null) { }
}

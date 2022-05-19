using Fluxor;
using MovieCentral.Client.Store.Features.Movie.Actions;
using MovieCentral.Client.Store.State;

namespace MovieCentral.Client.Store.Features.Movie.Reducers;

public static class LoadMovieReducers
{
    [ReducerMethod(typeof(LoadMovieAction))]
    public static MovieState ReduceLoadMovieAction(MovieState _)
        => new(FetchState.Loading, null, null);

    [ReducerMethod]
    public static MovieState ReduceLoadMovieSuccessAction(MovieState state, LoadMovieSuccessAction action)
        => state with { FetchState = FetchState.Success, Movie = action.MovieDto };

    [ReducerMethod]
    public static MovieState ReduceLoadMovieFailureAction(MovieState state, LoadMovieFailureAction action)
        => state with { FetchState = FetchState.Failure, ErrorMessage = action.Reason };
}

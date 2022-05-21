using Fluxor;
using MovieCentral.Client.Features.Movies.Store.Actions.LoadMovieList;
using MovieCentral.Client.Features.Shared;

namespace MovieCentral.Client.Features.Movies.Store.Reducers;

public static class LoadMovieListReducers
{
    [ReducerMethod]
    public static MovieListState ReduceLoadMovieListAction(MovieListState _, LoadMovieListAction action)
        => new(FetchState.Loading, action.Page, action.PageSize, 0, 0, action.Genre, null, null);

    [ReducerMethod]
    public static MovieListState ReduceLoadMovieListSuccessAction(MovieListState state, LoadMovieListSuccessAction action)
        => state with
        {
            FetchState = FetchState.Success,
            Movies = action.Movies,
            ErrorMessage = null,
            CurrentPage = action.CurrentPage,
            PageSize = action.PageSize,
            TotalCount = action.TotalCount,
            TotalPages = action.TotalPages,
        };

    [ReducerMethod]
    public static MovieListState ReduceLoadMovieListFailureAction(MovieListState state, LoadMovieListFailureAction action)
        => state with
        {
            FetchState = FetchState.Failure,
            ErrorMessage = action.Reason
        };
}

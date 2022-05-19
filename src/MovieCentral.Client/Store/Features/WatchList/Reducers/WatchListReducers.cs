using Fluxor;
using MovieCentral.Client.Store.Features.WatchList.Actions.AddWatchListItem;
using MovieCentral.Client.Store.Features.WatchList.Actions.LoadWatchList;
using MovieCentral.Client.Store.Features.WatchList.Actions.RemoveWatchListItem;
using MovieCentral.Client.Store.State;

namespace MovieCentral.Client.Store.Features.WatchList.Reducers;

public static class WatchListReducers
{
    [ReducerMethod(typeof(LoadWatchListAction))]
    public static WatchListState ReduceLoadWatchListAction(WatchListState _)
        => new(FetchState.Loading, null, null);

    [ReducerMethod]
    public static WatchListState ReduceLoadWatchListSuccessAction(WatchListState state, LoadWatchListSuccessAction action)
        => state with { FetchState = FetchState.Success, Movies = action.Movies, ErrorMessage = null };

    [ReducerMethod]
    public static WatchListState ReduceLoadWatchListFailureAction(WatchListState state, LoadWatchListFailureAction action)
        => state with { FetchState = FetchState.Failure, ErrorMessage = action.Reason };

    [ReducerMethod(typeof(AddWatchListItemAction))]
    public static WatchListState ReduceAddWatchListItemAction(WatchListState state)
        => state with { };

    [ReducerMethod(typeof(RemoveWatchListItemAction))]
    public static WatchListState ReduceRemoveWatchListItemAction(WatchListState state)
        => state with { };
}

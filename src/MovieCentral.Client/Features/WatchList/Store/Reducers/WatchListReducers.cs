using Fluxor;
using MovieCentral.Client.Features.Shared;
using MovieCentral.Client.Features.WatchList.Store;
using MovieCentral.Client.Features.WatchList.Store.Actions.AddWatchListItem;
using MovieCentral.Client.Features.WatchList.Store.Actions.LoadWatchList;
using MovieCentral.Client.Features.WatchList.Store.Actions.RemoveWatchListItem;

namespace MovieCentral.Client.Features.WatchList.Store.Reducers;

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

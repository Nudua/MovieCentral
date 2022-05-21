using Fluxor;
using MovieCentral.Client.Features.WatchList.Store.Actions.AddWatchListItem;
using MovieCentral.Client.Features.WatchList.Store.Actions.LoadWatchList;
using MovieCentral.Client.Features.WatchList.Store.Actions.RemoveWatchListItem;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Client.Features.WatchList;

public class WatchListFacade
{
    private readonly IDispatcher _dispatcher;

    public WatchListFacade(IDispatcher dispatcher) => _dispatcher = Guard.ThrowIfNull(dispatcher);

    public void AddMovie(Guid id) => _dispatcher.Dispatch(new AddWatchListItemAction(id));

    public void RemoveMovie(Guid id) => _dispatcher.Dispatch(new RemoveWatchListItemAction(id));

    public void Load() => _dispatcher.Dispatch(new LoadWatchListAction());
}

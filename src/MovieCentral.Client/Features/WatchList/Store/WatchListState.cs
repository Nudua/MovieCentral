using Fluxor;
using MovieCentral.Client.Features.Shared;
using MovieCentral.Shared.Dtos.WatchList;

namespace MovieCentral.Client.Features.WatchList.Store;

[FeatureState]
public record WatchListState(FetchState FetchState, List<WatchListItemDto> Movies, string ErrorMessage)
{
    private WatchListState() : this(FetchState.None, null, null) { }
}

using MovieCentral.Shared.Dtos.Movie;
using MovieCentral.Shared.Dtos.WatchList;

namespace MovieCentral.Client.Features.WatchList.Store.Actions.LoadWatchList;

public record LoadWatchListSuccessAction(List<WatchListItemDto> Movies);

using MovieCentral.Shared.Dtos.Movie;
using MovieCentral.Shared.Dtos.WatchList;

namespace MovieCentral.Client.Store.Features.WatchList.Actions.LoadWatchList;

public record LoadWatchListSuccessAction(List<WatchListItemDto> Movies);

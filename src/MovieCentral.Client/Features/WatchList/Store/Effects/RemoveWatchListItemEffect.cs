using System.Net.Http.Json;
using Fluxor;
using MovieCentral.Client.Features.WatchList.Store.Actions.LoadWatchList;
using MovieCentral.Client.Features.WatchList.Store.Actions.RemoveWatchListItem;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Client.Features.WatchList.Store.Effects;

public class RemoveWatchListItemEffect : Effect<RemoveWatchListItemAction>
{
    private readonly ILogger<RemoveWatchListItemEffect> _logger;
    private readonly HttpClient _httpClient;

    public RemoveWatchListItemEffect(ILogger<RemoveWatchListItemEffect> logger, HttpClient httpClient)
    {
        _logger = Guard.ThrowIfNull(logger);
        _httpClient = Guard.ThrowIfNull(httpClient);
    }

    public override async Task HandleAsync(RemoveWatchListItemAction action, IDispatcher dispatcher)
    {
        var response = await _httpClient.DeleteAsync($"api/watchlist/{action.MovieId}");

        if (response.IsSuccessStatusCode)
        {
            // Just reload the watchlist for now
            dispatcher.Dispatch(new LoadWatchListAction());
        }
        else
        {
            _logger.LogWarning("Unable to remove Movie with Id = {MovieId} from watchlist", action.MovieId);
        }
    }
}

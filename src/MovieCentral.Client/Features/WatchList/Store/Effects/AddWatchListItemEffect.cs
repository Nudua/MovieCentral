using System.Net.Http.Json;
using Fluxor;
using MovieCentral.Client.Features.WatchList.Store.Actions.AddWatchListItem;
using MovieCentral.Client.Features.WatchList.Store.Actions.LoadWatchList;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Client.Features.WatchList.Store.Effects;

public class AddWatchListItemEffect : Effect<AddWatchListItemAction>
{
    private readonly ILogger<AddWatchListItemEffect> _logger;
    private readonly HttpClient _httpClient;

    public AddWatchListItemEffect(ILogger<AddWatchListItemEffect> logger, HttpClient httpClient)
    {
        _logger = Guard.ThrowIfNull(logger);
        _httpClient = Guard.ThrowIfNull(httpClient);
    }

    public override async Task HandleAsync(AddWatchListItemAction action, IDispatcher dispatcher)
    {
        var response = await _httpClient.PostAsJsonAsync("api/watchlist", action.MovieId);

        if (response.IsSuccessStatusCode)
        {
            // Just reload the watchlist for now
            dispatcher.Dispatch(new LoadWatchListAction());
        }
        else
        {
            _logger.LogWarning("Unable to add Movie with Id = {MovieId} to watchlist", action.MovieId);
        }
    }
}

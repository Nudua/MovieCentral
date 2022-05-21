using System.Net.Http.Json;
using Fluxor;
using MovieCentral.Client.Features.WatchList.Store.Actions.LoadWatchList;
using MovieCentral.Shared.Dtos.WatchList;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Client.Features.WatchList.Store.Effects;

public class LoadWatchListEffect : Effect<LoadWatchListAction>
{
    private readonly ILogger<LoadWatchListEffect> _logger;
    private readonly HttpClient _httpClient;

    public LoadWatchListEffect(ILogger<LoadWatchListEffect> logger, HttpClient httpClient)
    {
        _logger = Guard.ThrowIfNull(logger);
        _httpClient = Guard.ThrowIfNull(httpClient);
    }

    public override async Task HandleAsync(LoadWatchListAction action, IDispatcher dispatcher)
    {
        var dto = await _httpClient.GetFromJsonAsync<List<WatchListItemDto>>("api/watchlist", DefaultJsonSerializerOptions.Instance);

        if (dto is not null)
        {
            dispatcher.Dispatch(new LoadWatchListSuccessAction(dto));
        }
        else
        {
            const string errorMessage = "Unable to load watchlist for logged in user.";
            _logger.LogWarning(errorMessage);
            dispatcher.Dispatch(new LoadWatchListFailureAction(errorMessage));
        }
    }
}

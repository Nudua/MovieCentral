using System.Net.Http.Json;
using Fluxor;
using MovieCentral.Client.Features.MovieDetails.Store.Actions;
using MovieCentral.Shared.Dtos.Movie;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Client.Features.MovieDetails.Store.Effects;

public class LoadMovieEffect : Effect<LoadMovieAction>
{
    private readonly ILogger<LoadMovieEffect> _logger;
    private readonly HttpClient _httpClient;

    public LoadMovieEffect(ILogger<LoadMovieEffect> logger, HttpClient httpClient)
    {
        _logger = Guard.ThrowIfNull(logger);
        _httpClient = Guard.ThrowIfNull(httpClient);
    }

    public override async Task HandleAsync(LoadMovieAction action, IDispatcher dispatcher)
    {
        var dto = await _httpClient.GetFromJsonAsync<MovieDetailedDto>("api/users/profile");

        if (dto is not null)
        {
            dispatcher.Dispatch(new LoadMovieSuccessAction(dto));
        }
        else
        {
            _logger.LogWarning("Unable to fetch Movie with Id = {MovieId}", action.Id);
            dispatcher.Dispatch(new LoadMovieFailureAction($"Movie with Id {action.Id} was not found."));
        }
    }
}

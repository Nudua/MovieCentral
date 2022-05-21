using System.Net.Http.Json;
using System.Text.Json;
using Fluxor;
using MovieCentral.Client.Features.Shared;
using MovieCentral.Client.Features.WatchList.Store;
using MovieCentral.Client.Store.Features.MovieList.Actions.LoadMovieList;
using MovieCentral.Shared;
using MovieCentral.Shared.Dtos.Movie;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Client.Store.Features.MovieList.Effects;

public class MovieSimpleDtoExtended : MovieSimpleDto
{
    public bool IsInWatchList { get; set; }
}

public class LoadMovieListEffect : Effect<LoadMovieListAction>
{
    private const string UnableToLoadErrorMessage = "Unable to Load Movie list, request url = {RequestUrl}";

    private readonly ILogger<LoadMovieListEffect> _logger;
    private readonly HttpClient _httpClient;
    private readonly IState<WatchListState> _watchListState;

    public LoadMovieListEffect(ILogger<LoadMovieListEffect> logger, IHttpClientFactory factory, IState<WatchListState> watchListState)
    {
        _logger = Guard.ThrowIfNull(logger);
        _httpClient = factory.CreateClient("UnauthenticatedClient");
        _watchListState = Guard.ThrowIfNull(watchListState);
    }

    public override async Task HandleAsync(LoadMovieListAction action, IDispatcher dispatcher)
    {
        var url = $"api/movies?pageNumber={action.Page}&pageSize={action.PageSize}&genre={action.Genre}";

        var response = await _httpClient.GetAsync(url);

        if (!response.IsSuccessStatusCode)
        {
            _logger.LogWarning(UnableToLoadErrorMessage, url);
            dispatcher.Dispatch(new LoadMovieListFailureAction("Unknown error."));
            return;
        }

        // Check Pagination Headers
        if (!response.Headers.TryGetValues("X-Pagination", out var values))
        {
            dispatcher.Dispatch(new LoadMovieListFailureAction("Missing pagination metadata."));
            return;
        }

        var paginationMetaData = JsonSerializer.Deserialize<PaginationMetaData>(values.First());

        var movies = await response.Content.ReadFromJsonAsync<List<MovieSimpleDtoExtended>>(DefaultJsonSerializerOptions.Instance);

        if (movies != null && paginationMetaData != null)
        {
            if (_watchListState.Value.FetchState == FetchState.Success)
            {
                // Check if any of our movies is in the users watchlist
                foreach (var movie in movies)
                {
                    movie.IsInWatchList = _watchListState.Value.Movies.Any(x => x.MovieId == movie.Id);
                }
            }

            dispatcher.Dispatch(new LoadMovieListSuccessAction(movies, paginationMetaData.CurrentPage, paginationMetaData.PageSize, paginationMetaData.TotalCount, paginationMetaData.TotalPages));
        }
        else
        {
            _logger.LogWarning(UnableToLoadErrorMessage, url);
            dispatcher.Dispatch(new LoadMovieListFailureAction("Failed to load data."));
        }
    }
}

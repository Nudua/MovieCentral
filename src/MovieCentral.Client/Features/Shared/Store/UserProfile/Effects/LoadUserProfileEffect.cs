using System.Net.Http.Json;
using Fluxor;
using MovieCentral.Client.Store.Features.UserProfile.Actions.LoadUserProfile;
using MovieCentral.Shared.Dtos.User;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Client.Store.Features.UserProfile.Effects;

public class LoadUserProfileEffect : Effect<LoadUserProfileAction>
{
    private readonly ILogger<LoadUserProfileEffect> _logger;
    private readonly HttpClient _httpClient;

    public LoadUserProfileEffect(ILogger<LoadUserProfileEffect> logger, HttpClient httpClient)
    {
        _logger = Guard.ThrowIfNull(logger);
        _httpClient = Guard.ThrowIfNull(httpClient);
    }

    public override async Task HandleAsync(LoadUserProfileAction action, IDispatcher dispatcher)
    {
        var userProfile = await _httpClient.GetFromJsonAsync<UserProfileDto>("api/users/profile");

        if (userProfile is not null)
        {
            _logger.LogInformation("Fetched UserProfile for user with NickName = {NickName}", action.NickName);
            dispatcher.Dispatch(new LoadUserProfileSuccessAction(userProfile.NickName));
        }
        else
        {
            _logger.LogWarning("Unable to fetch UserProfile for authenticated user with NickName = {NickName}", action.NickName);
        }
    }
}

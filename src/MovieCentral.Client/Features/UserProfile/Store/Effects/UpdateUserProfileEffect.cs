using System.Net.Http.Json;
using Fluxor;
using MovieCentral.Client.Features.UserProfile.Store.Actions.UpdateUserProfile;
using MovieCentral.Shared.Dtos.User;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Client.Features.UserProfile.Store.Effects;

public class UpdateUserProfileEffect : Effect<UpdateUserProfileAction>
{
    private readonly HttpClient _httpClient;

    public UpdateUserProfileEffect(HttpClient httpClient)
    {
        _httpClient = Guard.ThrowIfNull(httpClient);
    }

    public override async Task HandleAsync(UpdateUserProfileAction action, IDispatcher dispatcher)
    {
        var body = new UserNickNameForUpdateDto { NewNickName = action.NewNickName };
        var response = await _httpClient.PostAsJsonAsync("api/users/profile/updateNickName", body);

        if (response.IsSuccessStatusCode)
        {
            dispatcher.Dispatch(new UpdateUserProfileSuccessAction(action.NewNickName));
        }
        else
        {
            dispatcher.Dispatch(new UpdateUserProfileFailureAction("Invalid characters in the new nickname. Only alphanumeric values are allowed."));
        }
    }
}

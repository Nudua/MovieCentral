using Fluxor;
using MovieCentral.Client.Store.Features.UserProfile.Actions;
using MovieCentral.Client.Store.Features.UserProfile.Actions.LoadUserProfile;
using MovieCentral.Client.Store.Features.UserProfile.Actions.UpdateUserProfile;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Client.Features.Shared;

public class UserProfileFacade
{
    private readonly IDispatcher _dispatcher;

    public UserProfileFacade(IDispatcher dispatcher)
    {
        _dispatcher = Guard.ThrowIfNull(dispatcher);
    }

    public void Load(string nickName) => _dispatcher.Dispatch(new LoadUserProfileAction(nickName));

    public void UpdateNickName(string newNickName) => _dispatcher.Dispatch(new UpdateUserProfileAction(newNickName));

    public void Logout() => _dispatcher.Dispatch(new UserLoggedOutAction());
}

using Fluxor;
using MovieCentral.Client.Features.UserProfile.Store.Actions;
using MovieCentral.Client.Features.UserProfile.Store.Actions.LoadUserProfile;
using MovieCentral.Client.Features.UserProfile.Store.Actions.UpdateUserProfile;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Client.Features.UserProfile;

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

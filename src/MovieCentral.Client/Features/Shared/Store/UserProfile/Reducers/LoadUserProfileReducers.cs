using Fluxor;
using MovieCentral.Client.Features.Shared.Store.UserProfile;
using MovieCentral.Client.Features.Shared.Store.UserProfile.Actions;
using MovieCentral.Client.Features.Shared.Store.UserProfile.Actions.LoadUserProfile;

namespace MovieCentral.Client.Features.Shared.Store.UserProfile.Reducers;

public static class LoadUserProfileReducers
{
    [ReducerMethod]
    public static UserProfileState ReduceLoadUserProfileAction(UserProfileState _, LoadUserProfileAction action)
        => new(true, false, action.NickName);

    [ReducerMethod]
    public static UserProfileState ReduceLoadUserProfileSuccessAction(UserProfileState _, LoadUserProfileSuccessAction action)
        => new(false, true, action.NickName);

    [ReducerMethod(typeof(UserLoggedOutAction))]
    public static UserProfileState ReduceUserLoggedOutAction(UserProfileState _) => new(false, false, null);
}

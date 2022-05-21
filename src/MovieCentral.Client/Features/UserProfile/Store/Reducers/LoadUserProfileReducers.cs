using Fluxor;
using MovieCentral.Client.Features.UserProfile.Store;
using MovieCentral.Client.Features.UserProfile.Store.Actions;
using MovieCentral.Client.Features.UserProfile.Store.Actions.LoadUserProfile;

namespace MovieCentral.Client.Features.UserProfile.Store.Reducers;

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

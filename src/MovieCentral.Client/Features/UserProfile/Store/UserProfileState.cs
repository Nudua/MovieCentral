using Fluxor;

namespace MovieCentral.Client.Features.UserProfile.Store;

[FeatureState]
public record UserProfileState(bool IsLoading, bool IsLoggedIn, string NickName)
{
    private UserProfileState() : this(false, false, null) { }
}

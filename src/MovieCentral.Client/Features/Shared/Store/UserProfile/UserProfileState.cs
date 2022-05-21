using Fluxor;

namespace MovieCentral.Client.Features.Shared.Store.UserProfile;

[FeatureState]
public record UserProfileState(bool IsLoading, bool IsLoggedIn, string NickName)
{
    private UserProfileState() : this(false, false, null) { }
}

using Fluxor;

namespace MovieCentral.Client.Store.State;

[FeatureState]
public record UserProfileState(bool IsLoading, bool IsLoggedIn, string NickName)
{
    private UserProfileState() : this(false, false, null) { }
}

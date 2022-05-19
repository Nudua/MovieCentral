using MovieCentral.Shared.Dtos.User;

namespace MovieCentral.Application.Abstractions.Read;

public interface IReadOnlyUsersService
{
    Task<UserProfileDto> GetProfileAsync(Guid id, string NickName, CancellationToken cancellationToken = default);
}

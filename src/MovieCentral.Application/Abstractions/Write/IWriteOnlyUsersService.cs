using MovieCentral.Shared.Dtos.User;

namespace MovieCentral.Application.Abstractions.Write;

public interface IWriteOnlyUsersService
{
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    Task UpdateNickNameAsync(Guid id, UserNickNameForUpdateDto dto, CancellationToken cancellationToken = default);
}

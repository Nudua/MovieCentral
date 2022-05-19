using Microsoft.Extensions.Logging;
using MovieCentral.Application.Abstractions;
using MovieCentral.Application.Abstractions.Write;
using MovieCentral.Application.Exceptions;
using MovieCentral.Infrastructure.Persistence.ReadServices;
using MovieCentral.Shared.Dtos.User;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Infrastructure.Persistence.WriteServices;

public class WriteOnlyUsersService : IWriteOnlyUsersService
{
    private readonly IApplicationDbContext _dbContext;
    private readonly ILogger<ReadOnlyUsersService> _logger;

    public WriteOnlyUsersService(IApplicationDbContext dbContext, ILogger<ReadOnlyUsersService> logger)
    {
        _dbContext = Guard.ThrowIfNull(dbContext);
        _logger = Guard.ThrowIfNull(logger);
    }

    public async Task UpdateNickNameAsync(Guid id, UserNickNameForUpdateDto dto, CancellationToken cancellationToken = default)
    {
        var user = await _dbContext.Users.FindAsync(id);

        if (user is null)
        {
            _logger.LogWarning("Unable to get user profile with Guid = {Id} was not found.", id);
            throw new NotFoundException($"User with Id = {id} was not found.");
        }

        var oldNickName = user.NickName;
        user.NickName = dto.NewNickName;

        await _dbContext.SaveChangesAsync(cancellationToken);

        _logger.LogInformation("User with Id = {Id} updated nick from '{OldNickName} to {NewNickName}'", id, oldNickName, dto.NewNickName);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var user = await _dbContext.Users.FindAsync(id);

        if (user is null)
        {
            _logger.LogWarning("Unable to get user profile with Guid = {Id} was not found.", id);
            throw new NotFoundException($"User with Id = {id} was not found.");
        }

        _dbContext.Users.Remove(user);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}

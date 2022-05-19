using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieCentral.Application.Abstractions;
using MovieCentral.Application.Abstractions.Read;
using MovieCentral.Application.Exceptions;
using MovieCentral.Domain.Entities;
using MovieCentral.Shared.Dtos.User;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Infrastructure.Persistence.ReadServices;

public class ReadOnlyUsersService : IReadOnlyUsersService
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ILogger<ReadOnlyUsersService> _logger;

    public ReadOnlyUsersService(IApplicationDbContext dbContext, IMapper mapper, ILogger<ReadOnlyUsersService> logger)
    {
        _dbContext = Guard.ThrowIfNull(dbContext);
        _mapper = Guard.ThrowIfNull(mapper);
        _logger = Guard.ThrowIfNull(logger);
    }

    public async Task<UserProfileDto> GetProfileAsync(Guid id, string nickName, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Fetching user profile with Id = {Id}", id);

        // Create the user if it doesn't exist in our database
        if (!await _dbContext.Users.AnyAsync(x => x.Id == id, cancellationToken))
        {
            return await CreateNewUser(id, nickName, cancellationToken);
        }

        var user = await _dbContext.Users
                                         .AsNoTracking()
                                         .Where(x => x.Id == id)
                                         .ProjectTo<UserProfileDto>(_mapper.ConfigurationProvider)
                                         .FirstOrDefaultAsync(cancellationToken);

        if (user is null)
        {
            _logger.LogWarning("Unable to get user profile with Guid = {Id} was not found.", id);
            throw new NotFoundException($"User with Id = {id} was not found.");
        }

        return user;
    }

    private async Task<UserProfileDto> CreateNewUser(Guid id, string nickName, CancellationToken cancellationToken = default)
    {
        var user = new User { Id = id, NickName = nickName };
        _dbContext.Users.Add(user);

        await _dbContext.SaveChangesAsync(cancellationToken);
        _logger.LogInformation("Added new User with Id = {UserId} and Nickname = {NickName}", id, nickName);

        return _mapper.Map<UserProfileDto>(user);
    }
}

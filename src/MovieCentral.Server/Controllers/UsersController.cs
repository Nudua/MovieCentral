using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieCentral.Application.Abstractions.Read;
using MovieCentral.Application.Abstractions.Write;
using MovieCentral.Server.Extensions;
using MovieCentral.Shared.Dtos.Movie;
using MovieCentral.Shared.Dtos.User;
using MovieCentral.Shared.Utils;
using Swashbuckle.AspNetCore.Annotations;

namespace MovieCentral.Server.Controllers;

[Authorize]
[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IReadOnlyUsersService _readService;
    private readonly IWriteOnlyUsersService _writeService;

    public UsersController(IReadOnlyUsersService readService, IWriteOnlyUsersService writeService)
    {
        _readService = Guard.ThrowIfNull(readService);
        _writeService = Guard.ThrowIfNull(writeService);
    }

    [HttpGet("profile")]
    [SwaggerOperation(
        Summary = "Get the user's profile",
        Description = "Returns the profile of the authenticated user",
        OperationId = "GetUserProfile"
    )]
    [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(UserProfileDto))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
    public async Task<IActionResult> GetProfile(CancellationToken cancellationToken)
    {
        var userId = User.GetIdOrThrow();
        var name = User.GetNameOrThrow();
        return Ok(await _readService.GetProfileAsync(userId, name, cancellationToken));
    }

    [HttpDelete]
    [SwaggerOperation(
        Summary = "Deletes the current user",
        Description = "Deletes the user and all their associated data",
        OperationId = "DeleteUser"
    )]
    [SwaggerResponse(StatusCodes.Status204NoContent, "Successful operation")]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
    public async Task<IActionResult> DeleteUser(CancellationToken cancellationToken)
    {
        var userId = User.GetIdOrThrow();
        await _writeService.DeleteAsync(userId, cancellationToken);
        return NoContent();
    }

    [SwaggerOperation(
        Summary = "Update the nickname of the user",
        OperationId = "UpdateNickName"
    )]
    [HttpPost("profile/updateNickName")]
    public async Task<IActionResult> UpdateNickName([FromBody] UserNickNameForUpdateDto dto, CancellationToken cancellationToken)
    {
        var userId = User.GetIdOrThrow();
        await _writeService.UpdateNickNameAsync(userId, dto, cancellationToken);
        return Ok();
    }
}

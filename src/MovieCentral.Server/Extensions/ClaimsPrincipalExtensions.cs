using System.Security.Claims;
using MovieCentral.Application.Exceptions;

namespace MovieCentral.Server.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static Guid GetIdOrThrow(this ClaimsPrincipal User)
    {
        if (User.Identity?.IsAuthenticated is false)
        {
            throw new UnauthorizedException();
        }

        var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userIdString))
        {
            throw new UnauthorizedException("The NameIdentifier (sub) claim was not found on logged in user.");
        }

        if (!Guid.TryParse(userIdString, out var userId))
        {
            throw new UnauthorizedException($"An Invalid Id was found for the user. Id = {userId}");
        }

        return userId;
    }

    public static string GetNameOrThrow(this ClaimsPrincipal User)
    {
        if (User.Identity?.IsAuthenticated is false)
        {
            throw new UnauthorizedException();
        }

        if (User.Identity?.Name is not null)
        {
            return User.Identity.Name;
        }

        var nameClaimValue = User.FindFirstValue(ClaimTypes.Name);

        if (!string.IsNullOrEmpty(nameClaimValue))
        {
            return nameClaimValue;
        }

        var alternativeNameClaimValue = User.FindFirstValue("name");

        if (!string.IsNullOrEmpty(alternativeNameClaimValue))
        {
            return alternativeNameClaimValue;
        }

        throw new UnauthorizedException("The authenticated user must have a name claim value");
    }
}

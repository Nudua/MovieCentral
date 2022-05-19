using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieCentral.Application.Abstractions.Read;
using MovieCentral.Application.Abstractions.Write;
using MovieCentral.Server.Extensions;
using MovieCentral.Shared.Dtos.User;
using MovieCentral.Shared.Dtos.WatchList;
using Swashbuckle.AspNetCore.Annotations;

namespace MovieCentral.Server.Controllers;

[Authorize]
[ApiController]
[Route("api/watchlist")]
public class WatchListController : ControllerBase
{
    private readonly IReadOnlyWatchListService _readService;
    private readonly IWriteOnlyWatchListService _writeService;

    public WatchListController(IReadOnlyWatchListService readService, IWriteOnlyWatchListService writeService)
    {
        _readService = readService;
        _writeService = writeService;
    }

    [HttpGet]
    [SwaggerOperation(
        Summary = "Get the user's Watchlist",
        Description = "Returns the movie watchlist of the authenticated user",
        OperationId = "GetWatchlist"
    )]
    [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(IEnumerable<WatchListItemDto>))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
    public async Task<IActionResult> GetList(CancellationToken cancellationToken)
        => Ok(await _readService.GetAsync(User.GetIdOrThrow(), cancellationToken));

    [HttpDelete("{movieId:guid}")]
    [SwaggerOperation(Summary = "Remove Movie from Watchlist", OperationId = "RemoveWatchlistItem")]
    [SwaggerResponse(StatusCodes.Status204NoContent, "Successful operation")]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Movie was not found")]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
    public async Task<IActionResult> RemoveMovie([FromRoute, SwaggerParameter("ID of Movie to remove", Required = true)] Guid movieId, CancellationToken cancellationToken)
    {
        await _writeService.RemoveAsync(User.GetIdOrThrow(), movieId, cancellationToken);
        return NoContent();
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Add Movie to Watchlist", OperationId = "AddWatchlistItem")]
    [SwaggerResponse(StatusCodes.Status204NoContent, "Successful operation")]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Movie was not found")]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
    public async Task<IActionResult> AddMovie([FromBody, SwaggerParameter("ID of Movie to add", Required = true)] Guid movieId, CancellationToken cancellationToken)
    {
        await _writeService.AddAsync(User.GetIdOrThrow(), movieId, cancellationToken);
        return Ok();
    }
}

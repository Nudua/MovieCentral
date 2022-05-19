using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieCentral.Application.Abstractions.Read;
using MovieCentral.Shared.Dtos.Movie;
using MovieCentral.Shared.Dtos.Parameters;
using MovieCentral.Shared.Utils;
using Swashbuckle.AspNetCore.Annotations;

namespace MovieCentral.Server.Controllers;

[AllowAnonymous]
[ApiController]
[Route("api/movies")]
public class MoviesController : ControllerBase
{
    private readonly IReadOnlyMovieService _readService;

    public MoviesController(IReadOnlyMovieService readService)
    {
        _readService = Guard.ThrowIfNull(readService);
    }

    [HttpGet]
    [SwaggerOperation(
        Summary = "Get a paged list of movies",
        Description = "Returns a paged list of movies sorted by their popularity on imdb",
        OperationId = "GetMovieList"
    )]
    [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(IEnumerable<MovieSimpleDto>))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not found")]
    public async Task<IActionResult> GetPagedList([FromQuery] PagedMovieListParameters parameters, CancellationToken cancellationToken)
    {
        var pagedList = await _readService.GetPagedListAsync(parameters, cancellationToken);

        Response.Headers.Add("X-Pagination", pagedList.MetaData.ToJson());

        // Todo: Add hypermedia links?
        return Ok(pagedList.Items);
    }

    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Get Movie by ID", OperationId = "GetMovie")]
    [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(MovieDetailedDto))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not found")]
    public async Task<IActionResult> Get([FromRoute, SwaggerParameter("ID of the movie to get", Required = true)] Guid id, CancellationToken cancellationToken)
        => Ok(await _readService.GetAsync(id, cancellationToken));
}

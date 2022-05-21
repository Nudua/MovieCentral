using MovieCentral.Shared.Dtos.Movie;

namespace MovieCentral.Client.Store.Features.Movie.Actions;

public record LoadMovieSuccessAction(MovieDetailedDto MovieDto);

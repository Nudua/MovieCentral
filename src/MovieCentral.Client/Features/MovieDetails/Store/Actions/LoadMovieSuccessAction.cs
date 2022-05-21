using MovieCentral.Shared.Dtos.Movie;

namespace MovieCentral.Client.Features.MovieDetails.Store.Actions;

public record LoadMovieSuccessAction(MovieDetailedDto MovieDto);

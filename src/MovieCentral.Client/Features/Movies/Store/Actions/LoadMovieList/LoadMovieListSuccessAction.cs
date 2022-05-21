using MovieCentral.Client.Store.Features.MovieList.Effects;

namespace MovieCentral.Client.Store.Features.MovieList.Actions.LoadMovieList;

public record LoadMovieListSuccessAction(List<MovieSimpleDtoExtended> Movies, int CurrentPage, int PageSize, int TotalCount, int TotalPages);

using MovieCentral.Client.Features.Movies.Store.Effects;

namespace MovieCentral.Client.Features.Movies.Store.Actions.LoadMovieList;

public record LoadMovieListSuccessAction(List<MovieSimpleDtoExtended> Movies, int CurrentPage, int PageSize, int TotalCount, int TotalPages);

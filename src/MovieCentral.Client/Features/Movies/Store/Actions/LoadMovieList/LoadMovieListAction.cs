using MovieCentral.Shared.Constants;

namespace MovieCentral.Client.Store.Features.MovieList.Actions.LoadMovieList;

public record LoadMovieListAction(int Page, int PageSize, Genre Genre);

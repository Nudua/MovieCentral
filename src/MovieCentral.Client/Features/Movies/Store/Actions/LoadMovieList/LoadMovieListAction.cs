using MovieCentral.Shared.Constants;

namespace MovieCentral.Client.Features.Movies.Store.Actions.LoadMovieList;

public record LoadMovieListAction(int Page, int PageSize, Genre Genre);

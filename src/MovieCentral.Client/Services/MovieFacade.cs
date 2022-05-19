﻿using Fluxor;
using MovieCentral.Client.Store.Features.Movie.Actions;
using MovieCentral.Client.Store.Features.MovieList.Actions.LoadMovieList;
using MovieCentral.Shared.Constants;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Client.Services;

public class MovieFacade
{
    private readonly IDispatcher _dispatcher;

    public MovieFacade(IDispatcher dispatcher)
    {
        _dispatcher = Guard.ThrowIfNull(dispatcher);
    }

    public void LoadPagedList(int page, int pageSize, Genre genre)
        => _dispatcher.Dispatch(new LoadMovieListAction(page, pageSize, genre));

    public void LoadDetailed(Guid id) => _dispatcher.Dispatch(new LoadMovieAction(id));
}

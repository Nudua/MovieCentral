﻿using Fluxor;
using MovieCentral.Shared.Dtos.WatchList;

namespace MovieCentral.Client.Store.State;

[FeatureState]
public record WatchListState(FetchState FetchState, List<WatchListItemDto> Movies, string ErrorMessage)
{
    private WatchListState() : this(FetchState.None, null, null) { }
}

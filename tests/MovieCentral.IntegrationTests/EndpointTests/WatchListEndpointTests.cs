using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using MovieCentral.IntegrationTests.Helpers;
using MovieCentral.Shared.Dtos.WatchList;
using MovieCentral.Shared.Utils;
using Xunit;

namespace MovieCentral.IntegrationTests.EndpointTests;

public class WatchListEndpointTests : IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly HttpClient _client;
    private readonly HttpClient _unauthenticatedClient;

    public WatchListEndpointTests(CustomWebApplicationFactory<Program> factory)
    {
        _client = factory.CreateAuthenticatedClient();
        _unauthenticatedClient = factory.CreateUnAuthenticatedClient();
    }

    [Fact]
    public async Task WatchList_as_authenticated_user_is_returned()
    {
        var sut = MockData.AuthenticatedUser.WatchList;

        var response = await _client.GetAsync(Routes.WatchList.GetList);
        response.EnsureSuccessStatusCode();

        var watchListDtos = await response.Content.ReadFromJsonAsync<List<WatchListItemDto>>(DefaultJsonSerializerOptions.Instance);

        // Todo: Compare watchlist data in database with the dtos using BeEquivalentTo
        watchListDtos.Should().NotBeNull()
                     .And.HaveCount(sut.Count);
    }

    [Fact]
    public async Task Watchlist_as_unauthenticated_user_is_unauthorized()
    {
        var response = await _unauthenticatedClient.GetAsync(Routes.WatchList.GetList);
        response.Should().HaveStatusCode(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task Movie_is_added_to_watchlist()
    {
        var itemToAdd = MockData.Movies.Last();

        var response = await _client.GetAsync(Routes.WatchList.GetList);
        response.EnsureSuccessStatusCode();

        var beforeInsertWatchList = await response.Content.ReadFromJsonAsync<List<WatchListItemDto>>(DefaultJsonSerializerOptions.Instance);
        beforeInsertWatchList.Should().NotBeNull()
                             .And.NotContain(x => x.MovieId == itemToAdd.Id);

        var addResponse = await _client.PostAsJsonAsync(Routes.WatchList.AddMovie, itemToAdd.Id);
        addResponse.EnsureSuccessStatusCode();

        var afterInsertResponse = await _client.GetAsync(Routes.WatchList.GetList);
        afterInsertResponse.EnsureSuccessStatusCode();

        var afterInsertWatchList = await afterInsertResponse.Content.ReadFromJsonAsync<List<WatchListItemDto>>(DefaultJsonSerializerOptions.Instance);

        afterInsertWatchList.Should().NotBeNull()
                            .And.Contain(x => x.MovieId == itemToAdd.Id);
    }
    [Fact]
    public async Task Movie_is_removed_from_watchlist()
    {
        var itemToRemove = MockData.AuthenticatedUser.WatchList.First();

        var response = await _client.GetAsync(Routes.WatchList.GetList);
        response.EnsureSuccessStatusCode();

        var beforeInsertWatchList = await response.Content.ReadFromJsonAsync<List<WatchListItemDto>>(DefaultJsonSerializerOptions.Instance);
        beforeInsertWatchList.Should().NotBeNull()
                             .And.Contain(x => x.MovieId == itemToRemove.MovieFK);

        var addResponse = await _client.DeleteAsync(Routes.WatchList.RemoveMovie(itemToRemove.MovieFK));
        addResponse.EnsureSuccessStatusCode();

        var afterInsertResponse = await _client.GetAsync(Routes.WatchList.GetList);
        afterInsertResponse.EnsureSuccessStatusCode();

        var afterInsertWatchList = await afterInsertResponse.Content.ReadFromJsonAsync<List<WatchListItemDto>>(DefaultJsonSerializerOptions.Instance);

        afterInsertWatchList.Should().NotBeNull()
            .And.NotContain(x => x.MovieId == itemToRemove.MovieFK);
    }
}

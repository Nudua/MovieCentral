using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using MovieCentral.IntegrationTests.Helpers;
using MovieCentral.Shared;
using MovieCentral.Shared.Dtos.Movie;
using MovieCentral.Shared.Utils;
using Xunit;

namespace MovieCentral.IntegrationTests.EndpointTests;

public class MovieEndpointTests : IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public MovieEndpointTests(CustomWebApplicationFactory<Program> factory)
    {
        _client = factory.CreateAuthenticatedClient();
    }

    [Fact]
    public async Task Movie_that_exists_returns_correct_movie()
    {
        var movieMock = MockData.Movies.First();

        var response = await _client.GetAsync(Routes.Movies.Get(movieMock.Id));
        response.EnsureSuccessStatusCode();

        var movieDto = await response.Content.ReadFromJsonAsync<MovieDetailedDto>(DefaultJsonSerializerOptions.Instance);

        movieDto.Should().NotBeNull()
                .And.BeEquivalentTo(movieMock, options => options.ExcludingMissingMembers());
    }

    [Fact]
    public async Task Movie_that_does_not_exist_returns_not_found()
    {
        var response = await _client.GetAsync(Routes.Movies.Get(Guid.NewGuid()));
        response.Should().HaveStatusCode(HttpStatusCode.NotFound);
    }

    [Theory]
    [InlineData(1, 10)]
    [InlineData(4, 5)]
    [InlineData(7, 3)]
    [InlineData(2, 20)]
    public async Task Movies_with_valid_parameters_returns_correct_paginatedlist(int page, int pageSize)
    {
        var paginationMetaDataTarget = new PaginationMetaData(
            MockData.Movies.Count,
            pageSize,
            page,
            (int)Math.Ceiling(MockData.Movies.Count / (double)pageSize));

        var response = await _client.GetAsync(Routes.Movies.GetPagedList(page, pageSize));
        response.EnsureSuccessStatusCode();

        // Check Pagination Headers
        response.Headers.TryGetValues("X-Pagination", out var values).Should().BeTrue();
        values.Should().ContainSingle();

        var paginationMetaData = JsonSerializer.Deserialize<PaginationMetaData>(values.First());

        paginationMetaData.Should().NotBeNull()
                           .And.BeEquivalentTo(paginationMetaDataTarget);

        // Check the data
        var items = await response.Content.ReadFromJsonAsync<List<MovieSimpleDto>>(DefaultJsonSerializerOptions.Instance);

        items.Should().BeOfType<List<MovieSimpleDto>>()
             .And.HaveCount(pageSize)
             .And.BeInAscendingOrder(x => x.Ranking);
    }
}

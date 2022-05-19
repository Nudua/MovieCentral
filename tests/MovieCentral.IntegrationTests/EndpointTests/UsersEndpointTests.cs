using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using MovieCentral.IntegrationTests.Helpers;
using MovieCentral.Shared.Dtos.User;
using Xunit;

namespace MovieCentral.IntegrationTests.EndpointTests;

public class UsersEndpointTests : IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly HttpClient _client;
    private readonly HttpClient _unauthenticatedClient;

    public UsersEndpointTests(CustomWebApplicationFactory<Program> factory)
    {
        _client = factory.CreateAuthenticatedClient();
        _unauthenticatedClient = factory.CreateUnAuthenticatedClient();
    }

    [Fact]
    public async Task Userprofile_as_authenticated_user_is_valid()
    {
        var response = await _client.GetAsync(Routes.Users.Profile);
        response.EnsureSuccessStatusCode();

        var userProfileDto = await response.Content.ReadFromJsonAsync<UserProfileDto>();

        userProfileDto.NickName.Should().Be(MockData.AuthenticatedUser.NickName);
    }

    [Theory]
    [InlineData("Bob")]
    [InlineData("John")]
    [InlineData("Alice")]
    [InlineData("Sally")]
    public async Task Updating_nickname_with_compliant_nickname_is_valid(string newNickName)
    {
        var updateResponse = await _client.PostAsJsonAsync(Routes.Users.UpdateNickName, new UserNickNameForUpdateDto { NewNickName = newNickName });
        updateResponse.EnsureSuccessStatusCode();

        var response = await _client.GetAsync(Routes.Users.Profile);
        response.EnsureSuccessStatusCode();

        var userProfileDto = await response.Content.ReadFromJsonAsync<UserProfileDto>();

        userProfileDto.NickName.Should().Be(newNickName);
    }

    [Fact]
    public async Task UserProfile_as_unauthenticated_user_is_unauthorized()
    {
        var response = await _unauthenticatedClient.GetAsync(Routes.Users.Profile);
        response.Should().HaveStatusCode(HttpStatusCode.Unauthorized);
    }

    [Theory]
    [InlineData("Bob X'æÅ")]
    [InlineData(":;;:")]
    [InlineData("1\\23")]
    [InlineData("_.X")]
    public async Task Updating_nickname_with_bad_nickname_is_invalid(string badNickName)
    {
        var updateResponse = await _client.PostAsJsonAsync(Routes.Users.UpdateNickName, new UserNickNameForUpdateDto { NewNickName = badNickName });
        updateResponse.Should().HaveStatusCode(System.Net.HttpStatusCode.BadRequest);
    }
}

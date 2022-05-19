using System.Net.Http;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

namespace MovieCentral.IntegrationTests.Helpers;

public static class WebApplicationFactoryExtensions
{
    // Didn't end up using flurl
    //public static IFlurlClient CreateFlurlClient<TStartup>(this WebApplicationFactory<TStartup> factory)
    //    where TStartup : class
    //    => new FlurlClient(factory.CreateClient(new WebApplicationFactoryClientOptions { AllowAutoRedirect = false }));

    //public static IFlurlClient CreateAuthenticatedFlurlClient<TStartup>(this WebApplicationFactory<TStartup> factory)
    //where TStartup : class
    //    => new FlurlClient(factory.CreateAuthenticatedClient());

    public static HttpClient CreateAuthenticatedClient<TStartup>(this WebApplicationFactory<TStartup> factory)
        where TStartup : class
    {
        return factory.WithWebHostBuilder(builder =>
        {
            builder.ConfigureTestServices(services =>
            {
                services.AddAuthentication(TestAuthHandler.AuthenticationSchemeName)
                .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>(
                    TestAuthHandler.AuthenticationSchemeName,
                    _ => { });
            });
        }).CreateClient(new WebApplicationFactoryClientOptions { AllowAutoRedirect = false });
    }

    public static HttpClient CreateUnAuthenticatedClient<TStartup>(this WebApplicationFactory<TStartup> factory)
    where TStartup : class
    {
        return factory.WithWebHostBuilder(builder =>
        {
            builder.ConfigureTestServices(services =>
            {
                services.AddAuthentication(UnauthenticatedTestAuthHandler.AuthenticationSchemeName)
                .AddScheme<AuthenticationSchemeOptions, UnauthenticatedTestAuthHandler>(
                    UnauthenticatedTestAuthHandler.AuthenticationSchemeName,
                    _ => { });
            });
        }).CreateClient(new WebApplicationFactoryClientOptions { AllowAutoRedirect = false });
    }
}

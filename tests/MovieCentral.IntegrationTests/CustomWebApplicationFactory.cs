using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MovieCentral.Infrastructure.Persistence;

namespace MovieCentral.IntegrationTests;

public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
{
    private bool _disposed;
    private SqliteConnection _sqliteConnection;

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder
            .ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<ApplicationDbContext>));

                if (descriptor != null)
                {
                    // remove default (real) implementation
                    services.Remove(descriptor);
                }

                var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSqlite()
                .BuildServiceProvider();

                const string connectionString = "DataSource=:memory:";
                // We have to keep the connection alive to re-use it for multiple tests
                _sqliteConnection = new SqliteConnection(connectionString);
                _sqliteConnection.Open();

                services.AddDbContext<ApplicationDbContext>(
                    options =>
                    {
                        options.UseSqlite(_sqliteConnection);
                        options.UseInternalServiceProvider(serviceProvider);
                    });

                var sp = services.BuildServiceProvider();

                using var scope = sp.CreateScope();
                var scopedServices = scope.ServiceProvider;
                var dbContext = scopedServices.GetRequiredService<ApplicationDbContext>();

                var logger = scopedServices.GetRequiredService<ILogger<CustomWebApplicationFactory<TStartup>>>();

                dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();

                MockData.SeedDatabase(dbContext);
            });
    }

    protected override void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _sqliteConnection?.Dispose();
            }
        }

        base.Dispose(disposing);
        _disposed = true;
    }

    ~CustomWebApplicationFactory() => Dispose(false);
}

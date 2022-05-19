using System.Reflection;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using MovieCentral.Application.Abstractions;
using MovieCentral.Domain.Entities;

namespace MovieCentral.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public const string SQLiteConnectionStringPath = "AppDbContext";
    public const string PostgresConnectionStringPath = "PostgresDBContext";

    public DbSet<User> Users { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<WatchListItem> WatchListItems { get; set; }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        var seedMovies = ReadSeedDataFromFile("imdbtop250.json");

        builder.Entity<Movie>().HasData(seedMovies);
    }

    private static List<Movie> ReadSeedDataFromFile(string fileName)
    {
        var fullPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

        using var fileStream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
        return JsonSerializer.Deserialize<List<Movie>>(fileStream);
    }
}

using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using Microsoft.EntityFrameworkCore;
using MovieCentral.Domain.Entities;
using MovieCentral.Infrastructure.Persistence;

namespace MovieCentral.IntegrationTests;

public static class MockData
{
    private static readonly object _lock = new();

    public static List<Movie> Movies { get; }

    public static List<User> Users { get; }

    public static User AuthenticatedUser { get; }

    static MockData()
    {
        var fixture = new Fixture();

        var movies = new List<Movie>(
            fixture.Build<Movie>()
                   .Without(x => x.UsersWatchList)
                   .CreateMany(100));

        var users = new List<User>(
            fixture.Build<User>()
                   .Without(x => x.WatchList)
                   .CreateMany(10));

        AuthenticatedUser = users.First();

        // Add a bunch of watchlist items to the user
        for (int i = 0; i < users.Count; i++)
        {
            User user = users[i];
            var watchList = new List<WatchListItem>();

            for (int j = 0; j < 10; j++)
            {
                watchList.Add(new WatchListItem { UserFK = user.Id, MovieFK = movies[j].Id });
            }

            user.WatchList = watchList;
        }

        Movies = movies;
        Users = users;
    }

    public static void SeedDatabase(ApplicationDbContext context)
    {
        lock (_lock)
        {
            // Remove all seeded movies
            context.Database.ExecuteSqlRaw("DELETE FROM Movies");

            // Add our test data
            context.Movies.AddRange(Movies);
            context.Users.AddRange(Users);
            context.SaveChanges();
            context.ChangeTracker.Clear();
        }
    }
}

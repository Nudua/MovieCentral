using Microsoft.EntityFrameworkCore;
using MovieCentral.Domain.Entities;

namespace MovieCentral.Application.Abstractions;

public interface IApplicationDbContext
{
    DbSet<Movie> Movies { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<WatchListItem> WatchListItems { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

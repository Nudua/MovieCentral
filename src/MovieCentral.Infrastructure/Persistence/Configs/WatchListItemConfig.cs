using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieCentral.Domain.Entities;

namespace MovieCentral.Infrastructure.Persistence.Configs;

public class WatchListItemConfig : IEntityTypeConfiguration<WatchListItem>
{
    public void Configure(EntityTypeBuilder<WatchListItem> builder)
    {
        builder.HasKey(x => new { x.UserFK, x.MovieFK });

        builder.HasOne(x => x.User)
               .WithMany(x => x.WatchList)
               .HasForeignKey(x => x.UserFK);

        builder.HasOne(x => x.Movie)
               .WithMany(x => x.UsersWatchList)
               .HasForeignKey(x => x.MovieFK);

        builder.Property(x => x.Added)
               .IsRequired();
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieCentral.Domain.Entities;

namespace MovieCentral.Infrastructure.Persistence.Configs;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.NickName)
               .HasMaxLength(50)
               .IsRequired();

        // Note 2: Skipping this in favor of just configuring the join table manually with one to many relationships for each side
        // Note 1: Should probably just use Indirect many-to-many relationships instead of this complicated setup
        // https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key#join-entity-type-configuration
        //builder.HasMany(x => x.Movies)
        //       .WithMany(x => x.Users)
        //       .UsingEntity<WatchListItem>(
        //    j => j
        //    .HasOne(x => x.Movie)
        //    .WithMany(x => x.UsersWatchList)
        //    .HasForeignKey(x => x.MovieFK),
        //    j => j
        //    .HasOne(x => x.User)
        //    .WithMany(x => x.WatchList)
        //    .HasForeignKey(x => x.UserFK),
        //    j => j
        //    .HasKey(t => new { t.UserFK, t.MovieFK }));
    }
}

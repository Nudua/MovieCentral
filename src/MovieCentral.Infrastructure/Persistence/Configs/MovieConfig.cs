using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieCentral.Domain.Entities;

namespace MovieCentral.Infrastructure.Persistence.Configs;

public class MovieConfig : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
               .HasMaxLength(200)
               .IsRequired();

        builder.Property(x => x.Description)
               .HasMaxLength(500)
               .IsRequired();

        builder.Property(x => x.Genre)
               .IsRequired();

        builder.Property(x => x.Runtime)
               .IsRequired();

        builder.Property(x => x.ReleaseDate)
               .IsRequired(false);

        builder.Property(x => x.CoverUrl)
               .HasMaxLength(200)
               .IsRequired(false);

        builder.Property(x => x.Ranking)
               .IsRequired();
    }
}

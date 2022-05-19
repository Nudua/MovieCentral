using MovieCentral.Shared.Constants;

namespace MovieCentral.Shared.Dtos.Movie;

public class MovieDetailedDto
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public Genre Genre { get; set; }

    public TimeSpan Runtime { get; set; }

    public DateTime ReleaseDate { get; set; }

    public string Director { get; set; }

    public string CoverUrl { get; set; }

    public int Ranking { get; set; }
}

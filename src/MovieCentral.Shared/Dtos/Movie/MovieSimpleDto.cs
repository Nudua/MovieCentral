using MovieCentral.Shared.Constants;

namespace MovieCentral.Shared.Dtos.Movie;

public class MovieSimpleDto
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public string CoverUrl { get; set; }

    public int Ranking { get; set; }

    public Genre Genre { get; set; }
}

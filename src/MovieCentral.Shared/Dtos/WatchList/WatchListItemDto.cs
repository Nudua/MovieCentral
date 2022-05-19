using MovieCentral.Shared.Constants;

namespace MovieCentral.Shared.Dtos.WatchList;

public class WatchListItemDto
{
    public Guid MovieId { get; set; }

    public string Title { get; set; }

    public string CoverUrl { get; set; }

    public Genre Genre { get; set; }

    public int Ranking { get; set; }

    public DateTime Added { get; set; }
}

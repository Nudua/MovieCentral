using MovieCentral.Shared.Constants;

namespace MovieCentral.Domain.Entities;

public class Movie
{
    public Guid Id { get; set; }

    public string ImdbId { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public Genre Genre { get; set; }

    public TimeSpan Runtime { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string Director { get; set; }

    public string CoverUrl { get; set; }

    public string BackdropUrl { get; set; }

    public int Ranking { get; set; }

    // Users who has this movie in their watchlist, use UsersWatchList instead
    //public ICollection<User> Users { get; set; }

    // Join table for Movie <-> User
    public List<WatchListItem> UsersWatchList { get; set; }
}

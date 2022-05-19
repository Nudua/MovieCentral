namespace MovieCentral.Domain.Entities;

public class User
{
    public Guid Id { get; set; }

    public string NickName { get; set; }

    // Use UsersWatchList instead
    //public ICollection<Movie> Movies { get; set; }

    // Join table for User <-> Movie
    public List<WatchListItem> WatchList { get; set; }
}

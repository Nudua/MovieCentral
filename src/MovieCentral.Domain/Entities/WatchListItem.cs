namespace MovieCentral.Domain.Entities;

public class WatchListItem
{
    public User User { get; set; }

    public Guid UserFK { get; set; }

    public Movie Movie { get; set; }

    public Guid MovieFK { get; set; }

    public DateTime Added { get; set; }
}

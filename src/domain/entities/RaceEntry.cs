namespace domain.entities;
public sealed class RaceEntry
{
    public RaceEntry()
    {
        Crew = new HashSet<Crew>();
    }

    public Yacht? Yacht { get; set; }
    public Race? Race { get; set; }
    public IEnumerable<Crew> Crew { get; set; }
    public TimeSpan? RaceTime { get; set; }


}

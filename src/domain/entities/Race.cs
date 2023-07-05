namespace domain.entities;
public sealed class Race
{
    public Race()
    {

    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public YachtClub? HostingClub { get; set; }
    public DateOnly RaceDate { get; set; }
}

using domain.enums;

namespace domain.entities;
public sealed class Crew
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public Position position { get; set; }

    public Yacht? Yacht { get; set; }
    public Person? Person { get; set; }
}

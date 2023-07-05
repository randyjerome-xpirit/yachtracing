namespace domain.entities;
public sealed class Person
{
    public Person()
    {
        Crews = new HashSet<Crew>();   
        Yachts = new HashSet<Yacht>();
    }
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public IEnumerable<Crew> Crews { get; set; }
    public IEnumerable<Yacht> Yachts { get; set; }

}

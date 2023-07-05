namespace domain.entities;

public class Yacht
{
    public Yacht()
    {
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Make { get; set; }
    public string? Bio { get; set; } 
    public int Length { get; set; }
    public YachtClub? HomeYachtClub { get; set; }
    public Person? Owner { get; set; }

}


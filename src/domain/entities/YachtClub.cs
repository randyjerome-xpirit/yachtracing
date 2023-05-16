namespace domain.entities;

public class YachtClub
{
    public YachtClub()
    {
    }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address1 { get; set; } = string.Empty;
    public string Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}


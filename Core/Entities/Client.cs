namespace Core.Entities;

public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PassportNumber { get; set; }
    public string PhoneNumber { get; set; }
    
    public ICollection<Ticket> Tickets { get; set; }
}

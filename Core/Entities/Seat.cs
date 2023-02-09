namespace Core.Entities;

public class Seat
{
    public int Id { get; set; }
    public int FlightId { get; set; }
    public Flight Flight { get; set; }
    
    public string SeatNumber { get; set; }


    public int? TicketId { get; set; } = null;
    public Ticket? Ticket { get; set; } = null;

    // public ICollection<Ticket> TicketList { get; set; }
}

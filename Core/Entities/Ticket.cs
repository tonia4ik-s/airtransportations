namespace Core.Entities;

public class Ticket
{
    public int Id { get; set; }
    
    public int ClientId { get; set; }
    public Client Client { get; set; }
    
    public int FlightId { get; set; }
    public Flight Flight { get; set; }
    
    public int SeatId { get; set; }
    public Seat Seat { get; set; }
    
    public DateTimeOffset SellDate { get; set; }
}

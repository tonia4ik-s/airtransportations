namespace Core.Entities;

public class Flight
{
    public int Id { get; set; }
    public string FlightNumber { get; set; }
    
    public string DepartureAirportCode { get; set; }
    public Airport DepartureAirport { get; set; }
    
    public string ArrivalAirportCode { get; set; }
    public Airport ArrivalAirport { get; set; }
    
    public DateTimeOffset DepartureDateTime { get; set; }
    public DateTimeOffset ArrivalDateTime { get; set; }

    public string AircraftCode { get; set; }
    public Aircraft Aircraft { get; set; }
    
    public ICollection<Ticket> Tickets { get; set; }
    public ICollection<Seat> Seats { get; set; }
}

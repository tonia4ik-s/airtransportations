namespace Core.DTO;

public class TicketDTO
{
    public string FlightNumber { get; set; }
    public string ClientFirstName { get; set; }
    public string ClientLastName { get; set; }
    
    public string DepartureAirportName { get; set; }
    public string DepartureAirportCity { get; set; }
    public string DepartureAirportCountry { get; set; }
    public DateTimeOffset DepartureDateTime { get; set; }
    
    public string ArrivalAirportName { get; set; }
    public string ArrivalAirportCity { get; set; }
    public string ArrivalAirportCountry { get; set; }
    public DateTimeOffset ArrivalDateTime { get; set; }
    
    public DateTimeOffset SellDate { get; set; }
}

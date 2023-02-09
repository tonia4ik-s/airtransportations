namespace Core.Entities;

public class Airport
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    
    public ICollection<Flight> DepartureFlights { get; set; }
    public ICollection<Flight> ArrivalFlights { get; set; }
}

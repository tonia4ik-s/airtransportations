namespace Core.Entities;

public class Aircraft
{
    public string Code { get; set; }
    public string Model { get; set; }
    public float MaxFlightRange { get; set; }
    public int PassengerCapacity { get; set; }
    
    public ICollection<Flight> Flights { get; set; }
}

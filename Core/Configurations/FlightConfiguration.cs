using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Configurations;

public class FlightConfiguration : IEntityTypeConfiguration<Flight>
{
    public void Configure(EntityTypeBuilder<Flight> builder)
    {
        builder.HasOne(f => f.DepartureAirport)
            .WithMany(a => a.DepartureFlights)
            .HasForeignKey(f => f.DepartureAirportCode)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(f => f.ArrivalAirport)
            .WithMany(a => a.ArrivalFlights)
            .HasForeignKey(f => f.ArrivalAirportCode)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(f => f.Aircraft)
            .WithMany(a => a.Flights)
            .HasForeignKey(f => f.AircraftCode);
        builder.HasMany(f => f.Seats)
            .WithOne(s => s.Flight)
            .HasForeignKey(f => f.FlightId);
        builder.HasMany(f =>f.Tickets)
            .WithOne(t => t.Flight)
            .HasForeignKey(f => f.FlightId);
    }
}

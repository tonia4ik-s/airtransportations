using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Configurations;

public class AirportConfiguration : IEntityTypeConfiguration<Airport>
{
    public void Configure(EntityTypeBuilder<Airport> builder)
    {
        builder.HasKey(a => a.Code);
        builder.HasMany(a => a.DepartureFlights)
            .WithOne(f => f.DepartureAirport)
            .HasForeignKey(f => f.DepartureAirportCode);
        builder.HasMany(a => a.ArrivalFlights)
            .WithOne(f => f.ArrivalAirport)
            .HasForeignKey(f => f.ArrivalAirportCode);
    }
}

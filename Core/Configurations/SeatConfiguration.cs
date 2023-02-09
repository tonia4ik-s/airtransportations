using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Configurations;

public class SeatConfiguration : IEntityTypeConfiguration<Seat>
{
    public void Configure(EntityTypeBuilder<Seat> builder)
    {
        builder.HasOne(s => s.Flight)
            .WithMany(f => f.Seats)
            .HasForeignKey(s => s.FlightId);
        builder.HasOne(s => s.Ticket)
            .WithOne(t => t.Seat)
            .HasForeignKey<Seat>(s => s.TicketId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

using System.Reflection;
using Core.Configurations;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Data;

public class AirTransportationsDbContext : DbContext
{
    public AirTransportationsDbContext(DbContextOptions<AirTransportationsDbContext> options) 
        : base(options) { }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Airport> Airports { get; set; }
    public DbSet<Aircraft> Aircraft { get; set; }
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Seat> Seats { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ClientConfiguration))!);
        builder.SeedData();
        base.OnModelCreating(builder);
    }
}
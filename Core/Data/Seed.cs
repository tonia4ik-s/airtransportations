using Microsoft.EntityFrameworkCore;
using Bogus;
using Bogus.DataSets;
using Core.Entities;

namespace Core.Data;

public static class Seed
{
    private static readonly Faker Faker = new();
    
    public static void SeedData(this ModelBuilder builder)
    {
        SeedClients(builder);
        SeedAirports(builder);
        SeedAircraft(builder);
        SeedFlights(builder);
        SeedSeats(builder);
        SeedTickets(builder);
    }

    #region Clients

    private static void SeedClients(ModelBuilder builder)
    {
        var clients = new List<Client>();
        for (var i = 1; i <= 20; i++)
        {
            var person = new Person();
            clients.Add(new Client
            {
                Id = i,
                FirstName = person.FirstName,
                LastName = person.LastName,
                PassportNumber = Faker.Random.Hash(8).ToUpper(),
                PhoneNumber = person.Phone
            });
        }
        
        builder.Entity<Client>().HasData(clients);
    }

    #endregion

    #region Airports

    private static readonly string[] AirportCodes = {"UKBB", "EDDB", "KBMH", "LIMC", "KPHL", "PAR"};
    private static void SeedAirports(ModelBuilder builder)
    {
        var airports = new List<Airport>();
        for (var i = 0; i < 6; i++)
        {
            var address = new Address();
            var airport = new Airport
            {
                Code = AirportCodes[i],
                City = address.City(),
                Country = address.Country(),
                Latitude = address.Latitude(),
                Longitude = address.Longitude(),
                Name = new Company().CompanyName()
            };
            airports.Add(airport);
        }
        builder.Entity<Airport>().HasData(airports);
    }
    
    #endregion

    #region Aircraft

    private static readonly List<string> AircraftCodes = new()
    {
        Faker.Random.AlphaNumeric(3).ToUpper(),
        Faker.Random.AlphaNumeric(3).ToUpper(),
        Faker.Random.AlphaNumeric(3).ToUpper()
    };
    private static void SeedAircraft(ModelBuilder builder)
    {
        var boeing737 = new Aircraft
        {
            Code = AircraftCodes[0],
            Model = "Boeing 737-900",
            MaxFlightRange = 4440,
            PassengerCapacity = 215
        };
        var airbus320 = new Aircraft
        {
            Code = AircraftCodes[1],
            Model = "Airbus A321",
            MaxFlightRange = 5600,
            PassengerCapacity = 220
        };
        var boeing777 = new Aircraft
        {
            Code = AircraftCodes[2],
            Model = "Boeing 777-9",
            MaxFlightRange = 11100,
            PassengerCapacity = 426
        };

        builder.Entity<Aircraft>().HasData(boeing737, airbus320, boeing777);
    }

    #endregion

    #region Flights

    private static void SeedFlights(ModelBuilder builder)
    {
        var flights = new List<Flight>();
        var random  = new Random();
        for (var i = 0; i < 10; i++)
        {
            var departureDate = Faker.Date.SoonOffset(30);
            var timeSpan = Faker.Date.Timespan(new TimeSpan(1, 23, 59, 59));
            flights.Add(new Flight
            {
                Id = i+1,
                FlightNumber = "OA"+ random.NextInt64(10000),
                AircraftCode = AircraftCodes[random.Next(0, 3)],
                DepartureAirportCode = AirportCodes[random.Next(0,3)] ,
                ArrivalAirportCode = AirportCodes[random.Next(3,6)],
                DepartureDateTime = departureDate,
                ArrivalDateTime = departureDate + timeSpan
            });
        }

        builder.Entity<Flight>().HasData(flights);
    }

    #endregion

    #region Seats

    private static void SeedSeats(ModelBuilder builder)
    {
        var types = new [] { "A", "B" };
        var id = 1;
        var seats = new List<Seat>();
        for (var i = 0; i < 10; i++)
        {
            for (var j = 0; j < 60; j++)
            {
                seats.Add(new Seat
                {
                    Id = id, 
                    FlightId = i+1,
                    SeatNumber = $"{j + 1}" + types[j%2]
                });
                id++;
            }
        }

        builder.Entity<Seat>().HasData(seats);
    }

    #endregion

    #region Tickets

    private static void SeedTickets(ModelBuilder builder)
    {
        var random  = new Random();
        var tickets = new List<Ticket>();
        for (var i = 0; i < 50; i++)
        {
            tickets.Add(new Ticket
            {
                Id = i+1,
                ClientId = random.Next(1, 21),
                FlightId = i / 5 + 1,
                SeatId = (i + 1)*12,
                SellDate = Faker.Date.RecentOffset(30)
            });
        }
        
        builder.Entity<Ticket>().HasData(tickets);
    }

    #endregion
}

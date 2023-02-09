using AutoMapper;
using Core.Data;
using Core.DTO;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Services;

public class AirTransportationService
{
    private readonly AirTransportationsDbContext _context;
    private readonly IMapper _mapper;

    public AirTransportationService(AirTransportationsDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<TicketDTO>> GetTicketsByClient(int clientId)
    {
        var tickets = await _context.Set<Ticket>().Where(t => t.ClientId == clientId)
            .Include(t => t.Flight).ThenInclude(t => t.DepartureAirport)
            .Include(t => t.Flight).ThenInclude(t => t.ArrivalAirport)
            .Include(t => t.Client)
            .Include(t => t.Seat).ToListAsync();

        return tickets.Select(t => _mapper.Map<TicketDTO>(t)).ToList();
    }

    public List<ClientDTO> GetTopThreeClients()
    {
        return _context.Tickets
            .Include(t => t.Client)
            .AsEnumerable()
            .GroupBy(t => t.Client)
            .Select(c => new ClientDTO
            {
                Id = c.Key.Id,
                FirstName = c.Key.FirstName,
                LastName = c.Key.LastName,
                PassportNumber = c.Key.PassportNumber,
                PhoneNumber = c.Key.PhoneNumber ,
                FlightsAmount = c.Count()
            })
            .OrderByDescending(c => c.FlightsAmount).Take(3).ToList();
    }

    public async Task<List<TicketDTO>> GetLastFiveTickets()
    {
        var tickets = await _context.Set<Ticket>()
            .Include(t => t.Flight).ThenInclude(t => t.DepartureAirport)
            .Include(t => t.Flight).ThenInclude(t => t.ArrivalAirport)
            .Include(t => t.Client)
            .Include(t => t.Seat)
            .OrderByDescending(t => t.SellDate)
            .Take(5).ToListAsync();

        return tickets.Select(t => _mapper.Map<TicketDTO>(t)).ToList();
    }
}

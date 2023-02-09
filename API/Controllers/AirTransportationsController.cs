using Core.DTO;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AirTransportationsController : Controller
{
    private readonly AirTransportationService _airTransportationService;

    public AirTransportationsController(AirTransportationService airTransportationService)
    {
        _airTransportationService = airTransportationService;
    }

    [HttpGet("tickets")]
    public async Task<List<TicketDTO>> GetTicketsByClient(int clientId)
    {
        return await _airTransportationService.GetTicketsByClient(clientId);
    }

    [HttpGet("clients/top")]
    public IList<ClientDTO> GetTopClients()
    {
        return _airTransportationService.GetTopThreeClients();
    }

    [HttpGet("tickets/last")]
    public async Task<List<TicketDTO>> GetLastSoldTickets()
    {
        return await _airTransportationService.GetLastFiveTickets();
    }
}

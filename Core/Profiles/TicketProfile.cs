using AutoMapper;
using Core.DTO;
using Core.Entities;

namespace Core.Profiles;

public class TicketProfile : Profile
{
    public TicketProfile()
    {
        CreateMap<Ticket, TicketDTO>()
            .ForMember(d => d.FlightNumber,
                opt => opt
                    .MapFrom(s => s.Flight.FlightNumber))
            .ForMember(d => d.ArrivalAirportCity,
                opt => opt
                    .MapFrom(s => s.Flight.ArrivalAirport.City))
            .ForMember(d => d.ArrivalAirportCountry,
                opt => opt
                    .MapFrom(s => s.Flight.ArrivalAirport.Country))
            .ForMember(d => d.ArrivalAirportName,
                opt => opt
                    .MapFrom(s => s.Flight.ArrivalAirport.Name))
            .ForMember(d => d.DepartureAirportCity,
                opt => opt
                    .MapFrom(s => s.Flight.DepartureAirport.City))
            .ForMember(d => d.DepartureAirportCountry,
                opt => opt
                    .MapFrom(s => s.Flight.DepartureAirport.Country))
            .ForMember(d => d.DepartureAirportName,
                opt => opt
                    .MapFrom(s => s.Flight.DepartureAirport.Name))
            .ForMember(d => d.ArrivalDateTime,
                opt => opt
                    .MapFrom(s => s.Flight.ArrivalDateTime))
            .ForMember(d => d.DepartureDateTime,
                opt => opt
                    .MapFrom(s => s.Flight.DepartureDateTime))
            .ForMember(d => d.ClientFirstName,
                opt => opt
                    .MapFrom(s => s.Client.FirstName))
            .ForMember(d => d.ClientLastName,
                opt => opt
                    .MapFrom(s => s.Client.LastName));
    }
}
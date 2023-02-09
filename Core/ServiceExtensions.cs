using AutoMapper;
using Core.Data;
using Core.Profiles;
using Core.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Core;

public static class ServiceExtensions
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddScoped<AirTransportationService>();
    }

    public static void AddAutoMapper(this IServiceCollection services)
    {
        var configures = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new TicketProfile());
        });

        var mapper = configures.CreateMapper();
        services.AddSingleton(mapper);
    }
    
    public static void AddDbContext(this IServiceCollection service, string connectionString)
    {
        service.AddDbContext<AirTransportationsDbContext>
            (options => options.UseSqlServer(connectionString));
    }
}

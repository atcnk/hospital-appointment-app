using System.Reflection;
using Application.Services.DoctorService;
using Application.Services.DoctorScheduleService;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            services.AddScoped<IDoctorService, DoctorManager>();
            services.AddScoped<IDoctorScheduleService, DoctorScheduleManager>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}

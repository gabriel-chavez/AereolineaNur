using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Application.Services;
using MediatR;
using VentaReserva.Domain.Factories;

namespace VentaReserva.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddSingleton<IReservaService, ReservaService>();
            services.AddSingleton<IReservaFactory, ReservaFactory>();
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Reserva.Infraestructure.EF.Repositoty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Application;
using VentaReserva.Domain.Repositories;

namespace Reserva.Infraestructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services)
        {
            services.AddAplication();
            services.AddScoped<IReservaRepository,ReservaRepository >();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}

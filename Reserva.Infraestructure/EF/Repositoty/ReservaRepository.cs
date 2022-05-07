using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Domain.Repositories;

namespace Reserva.Infraestructure.EF.Repositoty
{
    public class ReservaRepository : IReservaRepository
    {
       
        public Task CreateAsync(VentaReserva.Domain.Model.Reserva.Reserva obj)
        {
            Console.WriteLine($"Insertando la reserva { obj.Id }");
                return Task.CompletedTask;
        }

        public Task<VentaReserva.Domain.Model.Reserva.Reserva> FindByIdAsync(Guid id)
        {
            Console.WriteLine($"retornando la reserva { id }");
                return null;
        }

        public Task UpdateAsync(VentaReserva.Domain.Model.Reserva.Reserva obj)
        {
            Console.WriteLine($"Actualizando la reserva { obj.Id }");
                return Task.CompletedTask;
        }
    }
}

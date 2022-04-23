using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Domain.Model.Pasajero;

namespace VentaReserva.Domain.Repositories
{
    public interface IPasajeroRepository : IRepository<Pasajero, Guid>
    {
        Task UpdateAsync(Pasajero obj);
    }
}

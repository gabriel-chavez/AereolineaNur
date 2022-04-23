using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Domain.Model.Reserva;

namespace VentaReserva.Domain.Repositories
{
    public interface IReservaRepository: IRepository<Reserva, Guid>
    {
        Task UpdateAsync(Reserva obj);
    }
}

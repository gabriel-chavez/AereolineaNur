using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Domain.Model.Pago;

namespace VentaReserva.Domain.Repositories
{
    public interface IPagoRepository : IRepository<Pago, Guid>
    {
        Task UpdateAsync(Pago obj);
    }
}

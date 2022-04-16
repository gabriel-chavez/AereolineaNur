using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Domain.Model.Pago
{
    public class Recibo: Entity<Guid>
    {
        public Guid IdPago { get; private set; }
        public string Descripcion { get; private set; }
        public Recibo(Guid idPago, string descripcion)
        {
            Id=Guid.NewGuid();
            IdPago = idPago;
            Descripcion = descripcion;
        }
    }
}

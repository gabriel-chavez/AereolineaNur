using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Domain.ValueObjets;

namespace VentaReserva.Domain.Model.Pago
{
    public class FacturaDetalle: Entity<Guid>
    {
        public int Cantidad { get; set; }
        public string LineaDetalle { get; set; }
        public PrecioValue Importe { get; set; }
        public PrecioValue ImporteTotal { get; set; }
    }
}

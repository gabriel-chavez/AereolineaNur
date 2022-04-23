using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Application.Dto.Pago
{
    public class FacturaDetalleDto
    {
        public int Cantidad { get; set; }
        public string LineaDetalle { get; set; }
        public decimal Importe { get; set; }
        public decimal ImporteTotal { get; set; }

    }
}

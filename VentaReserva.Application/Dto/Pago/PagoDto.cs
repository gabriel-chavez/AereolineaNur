using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Application.Dto.Pago
{
    public class PagoDto
    {
        public DateTime Fecha { get; private set; }
        public Guid IdReserva { get; private set; }
        public int MedioPago { get; private set; }
        public decimal Importe { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Application.Dto.Pago
{
    public class ReciboDto
    {
        public Guid IdPago { get; private set; }
        public string Descripcion { get; private set; }
    }
}

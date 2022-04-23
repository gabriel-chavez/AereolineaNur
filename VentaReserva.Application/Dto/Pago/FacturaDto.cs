using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Application.Dto.Pago
{
    public class FacturaDto
    {
        public Guid IdPago { get; private set; }
        public string NroAutorizacion { get; private set; }
        public int NroFactura { get; private set; }
        public decimal Monto { get; private set; }
        public int NitCi { get; private set; }
        public string Nombre { get; private set; }
        public ICollection<FacturaDetalleDto> Detalle { get; set; }

        public FacturaDto()
        {
            Detalle=new List<FacturaDetalleDto>();
        }
            
    }
}

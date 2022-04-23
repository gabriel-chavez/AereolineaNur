using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Application.Dto.Pago;

namespace VentaReserva.Application.UseCases.Command.Pago
{
    internal class CrearFacturaCommand: IRequest<Guid>
    {
        public List<FacturaDetalleDto> Detalle { get; set; }
        private CrearFacturaCommand() { }
        public CrearFacturaCommand(List<FacturaDetalleDto> detalle)
        {
            Detalle = detalle;
        }
            
    }
}

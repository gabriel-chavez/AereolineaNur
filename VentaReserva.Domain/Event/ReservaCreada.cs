using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Domain.Event
{
    public record ReservaCreada: DomainEvent
    {
        public Guid ReservaId { get; set; }
        public string CodigoVuelo { get; set; }
        public ReservaCreada(Guid reservaId, string codigoVuelo) : base(DateTime.Now)
        {
            ReservaId = reservaId;
            CodigoVuelo = codigoVuelo;
        }
    }
}

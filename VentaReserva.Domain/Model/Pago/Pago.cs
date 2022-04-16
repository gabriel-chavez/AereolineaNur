using ShareKernel.Core;
using ShareKernel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Domain.ValueObjets;

namespace VentaReserva.Domain.Model.Pago
{
    internal class Pago: AggregateRoot<Guid>
    {
        public DateTime Fecha { get; private set; }
        public Guid IdReserva { get; private set; }
        public MedioPagoEnum MedioPago { get; private set; }
        public PrecioValue Importe { get; private set; }
        public Pago(Guid idReserva, MedioPagoEnum medioPago, PrecioValue importe)
        {
            Id= Guid.NewGuid();
            Fecha = DateTime.Now;
            IdReserva = idReserva;
            MedioPago = medioPago;
            Importe = importe;
        }
    }
}

using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Domain.Event;
using VentaReserva.Domain.ValueObjets;

namespace VentaReserva.Domain.Model.Reserva
{
    public class Reserva : AggregateRoot<Guid>
    {
        public DateTime FechaHora { get; private set; }
        public int EstadoReserva { get; private set; }
        public Guid IdPasajero { get; private set; }
        public NroAsientoValue NroAsiento { get; private set; }
        public int TipoReserva { get; private set; }
        public PrecioValue Costo { get; private set; }
        public string CodigoVuelo { get; private set; }
        public Reserva(Guid idPasajero, NroAsientoValue nroAsiento, int tipoReserva, PrecioValue costo, string codigoVuelo)
        {
            Id= Guid.NewGuid();
            EstadoReserva = 1;
            FechaHora = DateTime.Now;
            IdPasajero = idPasajero;
            NroAsiento = nroAsiento;
            TipoReserva = tipoReserva;
            Costo = costo;
            CodigoVuelo = codigoVuelo;
        }
        public void FinalizarReserva()
        {
            var evento = new ReservaCreada(Id, CodigoVuelo);
            AddDomainEvent(evento);
        }


    }
}

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
        public DateTime? FechaHoraAnulacion { get; private set; }
        public int EstadoReserva { get; private set; }
        public Guid IdPasajero { get; private set; }
        public NroAsientoFilaValue NroAsientoFila { get; private set; }
        public NroAsientoColumnaValue NroAsientoColumna { get; private set; }
        public int TipoReserva { get; private set; }
        public PrecioValue Costo { get; private set; }
        public Guid IdVuelo { get; private set; }
        private Reserva()
        {

        }
        public Reserva(Guid idPasajero, NroAsientoFilaValue nroAsientoFila, NroAsientoColumnaValue nroAsientoColumna, int tipoReserva, PrecioValue costo, Guid idVuelo)
        {
            Id= Guid.NewGuid();
            EstadoReserva = 1;
            FechaHoraAnulacion = null;
            FechaHora = DateTime.Now;
            IdPasajero = idPasajero;
            NroAsientoFila = nroAsientoFila;
            NroAsientoColumna = nroAsientoColumna;
            TipoReserva = tipoReserva;
            Costo = costo;
            IdVuelo = idVuelo;
        }
        public void FinalizarReserva()
        {
            var evento = new ReservaCreada(Id, IdVuelo);
            AddDomainEvent(evento);
        }


    }
}

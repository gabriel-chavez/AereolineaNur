using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Domain.Model.Reserva;
using VentaReserva.Domain.ValueObjets;

namespace VentaReserva.Domain.Factories
{
    public class ReservaFactory : IReservaFactory
    {
        public Guid Anular(Guid idPasajero)
        {
            return idPasajero;
        }

        public Reserva Create(Guid idPasajero, NroAsientoFilaValue nroAsientoFila, NroAsientoColumnaValue nroAsientoColumna, int tipoReserva, PrecioValue costo, Guid idVuelo)
        {
            return new Reserva(idPasajero, nroAsientoFila, nroAsientoColumna, tipoReserva, costo, idVuelo);


        }
    }
}

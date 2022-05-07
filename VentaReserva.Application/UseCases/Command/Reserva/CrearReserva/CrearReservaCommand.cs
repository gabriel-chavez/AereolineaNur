using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Application.UseCases.Command.Reserva.CrearReserva
{
    public class CrearReservaCommand : IRequest<Guid>
    {
        public Guid IdPasajero { get; set; }
        public Guid IdVuelo { get; set; }
        public decimal Costo { get; set; }
        public int NroAsientoFila { get; set; }
        public char  NroAsientoColumna { get; set; }
        public int TipoReserva { get; set; }

        public CrearReservaCommand(int nroAsientoFila, char nroAsientoColumna, int tipoReserva, Guid idPasajero, Guid idVuelo, decimal costo)
        {

            NroAsientoFila = nroAsientoFila;
            NroAsientoColumna = nroAsientoColumna;
            TipoReserva = tipoReserva;
            IdPasajero = idPasajero;
            IdVuelo = idVuelo;
            Costo = costo;
        }
        public CrearReservaCommand()
        {

        }

    }
}

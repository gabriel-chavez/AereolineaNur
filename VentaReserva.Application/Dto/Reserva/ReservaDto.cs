using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Application.Dto.Reserva
{
    public class ReservaDto
    {
        public DateTime FechaHora { get;  set; }
        public int EstadoReserva { get;  set; }
        public Guid IdPasajero { get;  set; }
        public int Fila { get; set; }
        public char Columna { get; set; }
        public int TipoReserva { get;  set; }
        public decimal Costo { get;  set; }
        public string CodigoVuelo { get;  set; }
    }
}

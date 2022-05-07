using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Domain.ValueObjets;

namespace VentaReserva.Domain.Model.Vuelo
{
    public class Vuelo : AggregateRoot<Guid>
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLlegada { get; set; }
        public PrecioValue Precio { get; set; }
        public Vuelo(string origen, string destino, DateTime fecha, DateTime horaSalida, DateTime horaLlegada , PrecioValue precio)
        {
            Id = Guid.NewGuid();
            Origen = origen;
            Destino = destino;
            Fecha = fecha;
            HoraSalida = horaSalida;
            HoraLlegada = horaLlegada;
            Precio = precio;
        }

    }
}

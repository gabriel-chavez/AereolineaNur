using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Application.Dto.Pasajero
{
    public class PasajeroDto
    {
        public string NombreCompleto { get;  set; }
        public string Numero { get; set; }
        public int TipoDocumento { get; set;}
        public string Direccion { get;  set; }
        public string CorreoElectronico { get;  set; }
        public string Telefono { get;  set; }
    }
}

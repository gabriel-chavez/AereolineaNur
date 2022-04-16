using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Domain.Model.Pasajero
{
    public class Pasajero: AggregateRoot<Guid>
    {
        public PersonNameValue NombreCompleto { get; private set; }
        public DocumentoIdentidadValue DocumentoIdentidad { get; private set; }
        public string Direccion { get; private set; }
        public string CorreoElectronico { get; private set; }
        public string Telefono { get; private set; }
        public Pasajero(string nombreCompleto, DocumentoIdentidadValue documentoIdentidad, string direccion, string correoElectronico, string telefono)
        {
            Id = Guid.NewGuid();
            NombreCompleto = nombreCompleto;
            DocumentoIdentidad = documentoIdentidad;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
        }
    }
}

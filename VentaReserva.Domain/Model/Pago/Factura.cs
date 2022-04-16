using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Domain.ValueObjets;

namespace VentaReserva.Domain.Model.Pago
{
    public class Factura: Entity<Guid>
    {
        public Guid IdPago { get; private set; }
        public string NroAutorizacion { get; private set; }
        public int NroFactura { get; private set; }
        public PrecioValue Monto { get; private set; }
        public int NitCi { get; private set; }
        public string Nombre { get; private set; }
        public Factura(Guid idPago, string nroAutorizacion, int nroFactura, PrecioValue monto, int nitCi, string nombre)
        {
            Id = Guid.NewGuid();
            IdPago = idPago;
            NroAutorizacion = nroAutorizacion;
            NroFactura = nroFactura;
            Monto = monto;
            NitCi = nitCi;
            Nombre = nombre;
        }
    }
}

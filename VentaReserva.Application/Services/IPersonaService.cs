using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Application.Services
{
    public interface IPersonaService
    {
        Task<string> GenerarNroPersonaAsync();
    }
}

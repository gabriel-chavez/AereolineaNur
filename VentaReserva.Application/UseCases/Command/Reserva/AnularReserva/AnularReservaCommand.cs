using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaReserva.Application.UseCases.Command.Reserva.AnularReserva
{
    public class AnularReservaCommand: IRequest<Guid>
    {
        public Guid Id { get; set; }

        public AnularReservaCommand(Guid id)
        {
            Id = id;
        }
        public AnularReservaCommand()
        {

        }
    }
}

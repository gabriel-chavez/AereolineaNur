using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaReserva.Application.Dto.Reserva;

namespace VentaReserva.Application.UseCases.Queries.Reserva.GetReservaById
{
    public class GetReservaByIdQuery:IRequest<ReservaDto>
    {
        public Guid Id { get; set; }

        public GetReservaByIdQuery(Guid id)
        {
            Id = id;
        }
        public GetReservaByIdQuery()
        {

        }

    }
}

using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VentaReserva.Application.Dto.Reserva;
using VentaReserva.Domain.Repositories;

namespace VentaReserva.Application.UseCases.Queries.Reserva.GetReservaById
{
    public class GetReservaByIdHandler : IRequestHandler<GetReservaByIdQuery, ReservaDto>
    {
        public readonly IReservaRepository _reservaRepository;
        public readonly ILogger<GetReservaByIdQuery> _logger;
        public GetReservaByIdHandler(IReservaRepository reservaRepository, ILogger<GetReservaByIdQuery> logger)
        {
            _reservaRepository = reservaRepository;
            _logger = logger;
        }



        public async Task<ReservaDto> Handle(GetReservaByIdQuery request, CancellationToken cancellationToken)
        {
            ReservaDto result = null;
            try
            {
                VentaReserva.Domain.Model.Reserva.Reserva objReserva = await _reservaRepository.FindByIdAsync(request.Id);
                result = new ReservaDto()
                {
                    Id = objReserva.Id,
                    FechaHora = objReserva.FechaHora,
                    EstadoReserva = objReserva.EstadoReserva,
                    IdPasajero = objReserva.IdPasajero,
                    Fila = objReserva.NroAsientoFila,
                    Columna = objReserva.NroAsientoColumna,
                    TipoReserva = objReserva.TipoReserva,
                    Costo = objReserva.Costo,
                    IdVuelo = objReserva.IdVuelo

                };

            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}

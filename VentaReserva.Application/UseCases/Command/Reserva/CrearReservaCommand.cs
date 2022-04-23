using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VentaReserva.Domain.Repositories;

namespace VentaReserva.Application.UseCases.Command.Reserva
{
    public class CrearReservaCommand : IRequestHandler<CrearReservaCommand, Guid>
    {
        private readonly IReservaRepository _reservaRepository;
        private readonly ILogger<CrearReservaHandler> _logger;
        private readonly IReservaService _pedidoService;
        private readonly IPedidoFactory _pedidoFactory;
        private readonly IUnitOfWork _unitOfWork;
        public Task<Guid> Handle(CrearReservaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

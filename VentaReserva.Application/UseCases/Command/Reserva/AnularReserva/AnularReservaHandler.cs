using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VentaReserva.Application.Services;
using VentaReserva.Domain.Factories;
using VentaReserva.Domain.Repositories;

namespace VentaReserva.Application.UseCases.Command.Reserva.AnularReserva
{
    internal class AnularReservaHandler : IRequestHandler<AnularReservaCommand, Guid>
    {
        private readonly IReservaRepository _reservaRepository;
        private readonly ILogger<AnularReservaHandler> _logger;
        private readonly IReservaService _reservaService;
        private readonly IReservaFactory _reservaFactory;
        private readonly IUnitOfWork _unitOfWork;
        public AnularReservaHandler(IReservaRepository reservaRepository, ILogger<AnularReservaHandler> logger, IReservaService reservaService, IReservaFactory reservaFactory, IUnitOfWork unitOfWork)
        {
            _reservaRepository = reservaRepository;
            _logger = logger;
            _reservaService = reservaService;
            _reservaFactory = reservaFactory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(AnularReservaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var idReserva = _reservaFactory.Anular(request.Id);
               
                return idReserva;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Error al anular reserva");
            }
            return Guid.Empty;
        }









        
        public Guid IdPasajero=Guid.NewGuid();
        public int NroAsientoFila = 1;
        public char NroAsientoColumna = 'A';
        public int TipoReserva = 1;
        public decimal Costo = 100;
        public Guid IdVuelo= Guid.NewGuid();
    }
}

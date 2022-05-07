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
using VentaReserva.Domain.Model.Reserva;
using VentaReserva.Domain.Repositories;

namespace VentaReserva.Application.UseCases.Command.Reserva.CrearReserva
{
    public class CrearReservaHandler: IRequestHandler<CrearReservaCommand, Guid>
    {
        private readonly IReservaRepository _reservaRepository;
        private readonly ILogger<CrearReservaHandler> _logger;
        private readonly IReservaService _reservaService;
        private readonly IReservaFactory _reservaFactory;
        private readonly IUnitOfWork _unitOfWork;
        public CrearReservaHandler(IReservaRepository reservaRepository, ILogger<CrearReservaHandler> logger, IReservaService reservaService, IReservaFactory reservaFactory, IUnitOfWork unitOfWork)
        {
            _reservaRepository = reservaRepository;
            _logger = logger;
            _reservaService = reservaService;
            _reservaFactory = reservaFactory;
            _unitOfWork = unitOfWork;
        }


        public async Task<Guid> Handle(CrearReservaCommand request, CancellationToken cancellationToken)
        {
            try
            {

             //   string nroReserva = await _reservaService.GenerarNroReservaAsync();
                VentaReserva.Domain.Model.Reserva.Reserva objReserva = _reservaFactory.Create(request.IdPasajero,request.NroAsientoFila,request.NroAsientoColumna,request.TipoReserva,request.Costo,request.IdVuelo);
                objReserva.FinalizarReserva();
                await _reservaRepository.CreateAsync(objReserva);
                await _unitOfWork.Commit();



                return objReserva.Id;   
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Error al crear pedido");
            }
            return Guid.Empty;
        }
    }
}

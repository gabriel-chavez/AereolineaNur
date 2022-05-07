using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VentaReserva.Application.UseCases.Command.Reserva.CrearReserva;

namespace Reserva.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearReservaCommand command)
        {
            Guid id = await _mediator.Send(command);
            return Ok(id);
        }
    }
}

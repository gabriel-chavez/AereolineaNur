using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VentaReserva.Application.Dto.Reserva;
using VentaReserva.Application.UseCases.Command.Reserva.CrearReserva;
using VentaReserva.Application.UseCases.Queries.Reserva.GetReservaById;

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
        [Route("{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> GetReservaById([FromRoute] GetReservaByIdQuery command)
        {
            ReservaDto result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}

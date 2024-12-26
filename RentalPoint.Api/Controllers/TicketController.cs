using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TicketBookingApplication.Api.Dto;
using TicketBookingApplication.Api.Interfaces.Services;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;

        public TicketController(
            ITicketService ticketService,
            IMapper mapper)
        {
            _ticketService = ticketService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var rental = await _ticketService.GetByIdAsync(id, cancellationToken);

            var rentalResponse = _mapper.Map<TicketResponse>(rental);

            return Ok(rentalResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var rentals = await _ticketService.GetAllAsync(cancellationToken);

            var rentalsResponse = _mapper.Map<List<TicketResponse>>(rentals);

            return Ok(rentalsResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TicketRequest dto, CancellationToken cancellationToken)
        {
            var rental = _mapper.Map<Ticket>(dto);

            await _ticketService.CreateAsync(rental, cancellationToken);

            return Created();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            await _ticketService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }
    }
}

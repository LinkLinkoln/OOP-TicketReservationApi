using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TicketBookingApplication.Api.Dto;
using TicketBookingApplication.Api.Interfaces.Services;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientController(
            IClientService clientService,
            IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var client = await _clientService.GetByIdAsync(id, cancellationToken);

            var clientResponse = _mapper.Map<ClientResponse>(client); ;

            return Ok(clientResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var clients = await _clientService.GetAllAsync(cancellationToken);

            var clientsResponse = _mapper.Map<List<ClientResponse>>(clients);

            return Ok(clientsResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ClientRequest dto, CancellationToken cancellationToken)
        {
            var client = _mapper.Map<Client>(dto);

            await _clientService.CreateAsync(client, cancellationToken);

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] ClientRequest dto, CancellationToken cancellationToken)
        {
            var client = _mapper.Map<Client>(dto);

            await _clientService.UpdateAsync(id, client, cancellationToken);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            await _clientService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }
    }
}

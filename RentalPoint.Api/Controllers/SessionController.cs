using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TicketBookingApplication.Api.Dto;
using TicketBookingApplication.Api.Interfaces.Services;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionController : ControllerBase
    {
        private readonly ISessionService _sessionService;
        private readonly IMapper _mapper;

        public SessionController(
            ISessionService sessionService,
            IMapper mapper)
        {
            _sessionService = sessionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var categories = await _sessionService.GetAllAsync(cancellationToken);

            var categoriesResponse = _mapper.Map<List<SessionResponse>>(categories);

            return Ok(categoriesResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SessionRequest dto, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Session>(dto);

            await _sessionService.CreateAsync(category, cancellationToken);

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] SessionRequest dto, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Session>(dto);

            await _sessionService.UpdateAsync(id, category, cancellationToken);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            await _sessionService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }
    }
}

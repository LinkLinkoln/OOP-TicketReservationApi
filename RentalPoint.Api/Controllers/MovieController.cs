using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TicketBookingApplication.Api.Dto;
using TicketBookingApplication.Api.Interfaces.Services;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public MovieController(
            IMovieService movieService,
            IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var item = await _movieService.GetByIdAsync(id, cancellationToken);

            var itemResponse = _mapper.Map<MovieResponse>(item);

            return Ok(itemResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var items = await _movieService.GetAllAsync(cancellationToken);

            var itemsResponse = _mapper.Map<List<MovieResponse>>(items);

            return Ok(itemsResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MovieRequest dto, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<Movie>(dto);

            await _movieService.CreateAsync(item, cancellationToken);

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] MovieRequest dto, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<Movie>(dto);

            await _movieService.UpdateAsync(id, item, cancellationToken);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Update(Guid id,  CancellationToken cancellationToken)
        {
            await _movieService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TicketBookingApplication.Api.Dto;
using TicketBookingApplication.Api.Interfaces.Services;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;
        private readonly IMapper _mapper;

        public GenreController(
            IGenreService genreService,
            IMapper mapper)
        {
            _genreService = genreService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var categories = await _genreService.GetAllAsync(cancellationToken);

            var categoriesResponse = _mapper.Map<List<GenreResponse>>(categories);

            return Ok(categoriesResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] GenreRequest dto, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Genre>(dto);

            await _genreService.CreateAsync(category, cancellationToken);

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] GenreRequest dto, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Genre>(dto);

            await _genreService.UpdateAsync(id, category, cancellationToken);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            await _genreService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }
    }
}

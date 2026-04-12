using CleanArchitecutreMovies.Application.Commands;
using CleanArchitecutreMovies.Application.Queries;
using CleanArchitecutreMovies.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureMovies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("director/{directorName}")]
        public async Task<ActionResult<IEnumerable<MovieResponse>>> GetByDirector(string directorName)
        {
            var query = new GetMoviesByDirectorNameQuery(directorName);
            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MovieResponse>> Create([FromBody] CreateMovieCommand command)
        {
            if (command == null)
            {
                return BadRequest();
            }

            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}

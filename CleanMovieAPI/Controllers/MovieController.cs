using CleanMovie.Application.Commands;
using CleanMovie.Application.Queries;
using CleanMovie.Application.Services;
using CleanMovie.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovieAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly IMediator _mediator;

        public MovieController(IMediator mediator) 
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task <List<Movie>> Get()
        {
            return await _mediator.Send(new GetMovieListQuery());
        }
        [HttpPost]
        public async Task<ActionResult<Movie>> Create(CreateMovieCommand command)
        {
            return await _mediator.Send(command);
        }
        [HttpPut]
        public async Task<ActionResult<Movie>> Update(UpdateMovieCommand command)
        {
            return await _mediator.Send(command);
        }
        [HttpDelete]
        public async Task<bool> DeleteStudentAsync(int Id)
        {
            return await _mediator.Send(new DeleteMovieCommand() { Id = Id });
        }

    }
}

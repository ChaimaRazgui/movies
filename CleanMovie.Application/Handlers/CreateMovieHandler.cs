using CleanMovie.Application.Commands;
using CleanMovie.Application.Queries;
using CleanMovie.Application.Repositories;
using CleanMovie.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Handlers
{
    internal class CreateMovieHandler : IRequestHandler<CreateMovieCommand, Movie>
    {
        private readonly IMovieRepsitory _movieRepsitory;

        public CreateMovieHandler(IMovieRepsitory movieRepsitory )
        {
            _movieRepsitory = movieRepsitory;
        }
        public Task<Movie> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            var entity = new Movie
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description
            };
            return Task.FromResult(_movieRepsitory.CreateMovie(entity));
        }
    }
}

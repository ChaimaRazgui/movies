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
    public class UpdateCommandHandler : IRequestHandler<UpdateMovieCommand,Movie>
    {
        private readonly IMovieRepsitory _movieRepsitory;

        public UpdateCommandHandler(IMovieRepsitory movieRepsitory)
        {
            _movieRepsitory = movieRepsitory;
        }
        public Task<Movie> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
        {
            var entity = new Movie
            {   Id = request.Id,
                Name = request.Name,
                Description = request.Description
            };

            return Task.FromResult(_movieRepsitory.UpdateMovie(entity));
        }
      
    }
}

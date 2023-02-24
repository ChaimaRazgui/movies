using CleanMovie.Application.Commands;
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
    public class DeleteMovieHandler : IRequestHandler<DeleteMovieCommand,bool>
    {
        private readonly IMovieRepsitory _movieRepsitory;

        public DeleteMovieHandler (IMovieRepsitory movieRepsitory)
        {
            _movieRepsitory = movieRepsitory;
        }

        public Task<bool> Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
        {
            {
                var movieDetails =  _movieRepsitory.GetMovieById(request.Id);
                if (movieDetails == null)
                    return default;

                return Task.FromResult(_movieRepsitory.DeleteMovie(movieDetails.Id));
            }
        }
    }
}

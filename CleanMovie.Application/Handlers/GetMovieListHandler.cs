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
    public class GetMovieListHandler : IRequestHandler<GetMovieListQuery, List<Movie>>
    {
        private readonly IMovieRepsitory _movieRepsitory;

        public GetMovieListHandler(IMovieRepsitory movieRepsitory)
        {
            _movieRepsitory = movieRepsitory;
        }
        public Task<List<Movie>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_movieRepsitory.GetAllMovies());
        }
    }
}

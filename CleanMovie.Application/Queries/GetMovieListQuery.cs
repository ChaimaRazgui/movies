using CleanMovie.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Queries
{
    public record GetMovieListQuery() : IRequest<List<Movie>>;
  
}

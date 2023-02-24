using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Commands
{
    public record DeleteMovieCommand : IRequest<bool>
    {
        public int Id { get; set; } 
    }
}

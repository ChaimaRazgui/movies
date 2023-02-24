using CleanMovie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Repositories
{
    public interface IMovieRepsitory
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
        Movie UpdateMovie(Movie movie);
        Movie GetMovieById(int Id);
        bool DeleteMovie(int Id);
    }
}

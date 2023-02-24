using CleanMovie.Application.Repositories;
using CleanMovie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepsitory _movieRepsitory;
        public MovieService (IMovieRepsitory movieRepository)
        {
            _movieRepsitory= movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieRepsitory.CreateMovie(movie); 
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepsitory.GetAllMovies();
            return movies;
        }
    }
}

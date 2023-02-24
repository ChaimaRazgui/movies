using CleanMovie.Application.Repositories;
using CleanMovie.Domain.Entities;
using CleanMovie.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepsitory
    {
       
        private readonly MovieDbContext _movieDbContext;

        public MovieRepository (MovieDbContext movieDbContext)
        {
           _movieDbContext = movieDbContext;
        }
        public Movie CreateMovie(Movie movie)
        {
            _movieDbContext.Movies.Add(movie);  
            _movieDbContext.SaveChanges();
            return movie;
        }
     


        public List<Movie> GetAllMovies()
        {
           return _movieDbContext.Movies.ToList();
        }

        public Movie UpdateMovie(Movie movie)
        {
            var result = _movieDbContext.Update(movie);
            _movieDbContext.SaveChanges();
            return result.Entity;
        }
        public Movie GetMovieById(int Id)
        {
            return _movieDbContext.Movies.Where(x => x.Id == Id).FirstOrDefault();
        }

        public bool DeleteMovie(int Id)
        {
            var filteredData = _movieDbContext.Movies.Where(x => x.Id == Id).FirstOrDefault();
            var result = _movieDbContext.Remove(filteredData);
            _movieDbContext.SaveChanges();
            return result != null ? true : false;
        }
    }
}

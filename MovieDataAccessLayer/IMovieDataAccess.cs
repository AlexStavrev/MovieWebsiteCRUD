using MovieClassLibrary;
using System;
using System.Collections.Generic;

namespace MovieDataAccessLayer
{
    public interface IMovieDataAccess
    {
        public IEnumerable<Movie> GetAll();
        public Movie GetMovieById(int id);
        public Movie GetMovieByPartOfTitle(string partOfMovieTitle);
        public int AddMovie(Movie movie);
        public bool DeleteMovie(int id);
        public bool UpdateMovie(Movie movie);
    }
}

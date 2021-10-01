using MovieClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDataAccessLayer
{
    public class MovieSqlDbDataAccess : IMovieDataAccess
    {
        public int AddMovie(Movie Movie)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieByPartOfTitle(string partOfMovieTitle)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMovie(Movie Movie)
        {
            throw new NotImplementedException();
        }
    }
}

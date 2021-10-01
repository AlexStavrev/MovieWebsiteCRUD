using MovieClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDataAccessLayer
{
    public class MovieInMemoryDataAccess : IMovieDataAccess
    {
        private List<Movie> movies = new List<Movie>();
        private int nextId = 0;

        public MovieInMemoryDataAccess()
        {
            AddMovie(new Movie() {Title="Gone with the wind", Description= "A manipulative woman and a roguish man conduct a turbulent romance during the American Civil War and Reconstruction periods.", KidFriendly = true, ImdbScore = 8.1m });
            AddMovie(new Movie() { Title = "The Shawshank Redemption", Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", KidFriendly=false, ImdbScore=9.3m });
            AddMovie(new Movie() { Title = "The Matrix", Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", KidFriendly = false, ImdbScore = 8.7m });
            AddMovie(new Movie() { Title = "Coco", Description = "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead to find his great-great-grandfather, a legendary singer.", KidFriendly = true, ImdbScore = 8.4m });
            AddMovie(new Movie() { Title = "Forrest Gump", Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", KidFriendly = false, ImdbScore = 8.8m });
        }

        public int AddMovie(Movie movie)
        {
            movie.Id = GetNextId();
            movies.Add(movie);
            return movie.Id;
        }

        public bool DeleteMovie(int id)
        {
            return movies.Remove(movies.Find(movie => movie.Id == id));
        }

        public IEnumerable<Movie> GetAll()
        {
            return new List<Movie>(movies);
        }

        public Movie GetMovieById(int id)
        {
            return movies.Find(movie => movie.Id == id);
        }

        public Movie GetMovieByPartOfTitle(string partOfMovieTitle)
        {
            return movies.Find(movie => movie.Title.Contains(partOfMovieTitle, StringComparison.InvariantCultureIgnoreCase));
        }

        public bool UpdateMovie(Movie updatedMovie)
        {
            Movie existingMovie = GetMovieById(updatedMovie.Id);
            if (existingMovie == null) { return false; }
            CopyValues(existingMovie, updatedMovie);
            return true;
        }

        private static void CopyValues(Movie existingMovie, Movie updatedMovie)
        {
            existingMovie.Title = updatedMovie.Title;
            existingMovie.Description = updatedMovie.Description;
            existingMovie.KidFriendly = updatedMovie.KidFriendly;
            existingMovie.ImdbScore = updatedMovie.ImdbScore;
        }

        private int GetNextId()
        {
            nextId++;
            return nextId;
        }
    }
}

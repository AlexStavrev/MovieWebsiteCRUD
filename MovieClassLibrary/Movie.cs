using System;

namespace MovieClassLibrary
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool KidFriendly { get; set; }
        public decimal ImdbScore { get; set; }
    }
}

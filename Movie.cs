using System.Collections.Generic;

namespace SuncoastMovies
{
    public class Movie
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string PrimaryDirector { get; set; }
        public int YearReleased { get; set; }
        public string Genre { get; set; }
        public int RatingId { get; set; }

        //property that gives back the Rating object for this movie
        //       
        //      Name of the class    
        //        |    Name of the property
        //        |     |
        //        v     v    
        public Rating Rating { get; set; }

        // one to many relationship
        public List<Role> Roles { get; set; }
    }
}
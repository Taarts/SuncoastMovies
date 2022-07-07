using System;
using System.Linq;

namespace SuncoastMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SuncoastMoviesContext();

            var movieCount = context.Movies.Count();
            Console.WriteLine($"There are {movieCount} movies!");

            foreach (var movie in context.Movies)
            {
                Console.WriteLine($"There is a movie named {movie.Title}");

            }
        }
    }
}

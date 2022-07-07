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
        }
    }
}

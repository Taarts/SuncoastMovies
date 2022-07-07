using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SuncoastMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SuncoastMoviesContext();

            var movieCount = context.Movies.Count();
            Console.WriteLine($"There are {movieCount} movies!");

            //                                     JOIN             Rating/Role/Actor
            var moviesWithRatingsRolesAndActors = context.Movies.
                                                  // from our movie, pls include the associated Rating object
                                                  Include(movie => movie.Rating).
                                                  // & from our movie, pls include the associated Roles LIST
                                                  Include(movie => movie.Roles).
                                                  // THEN for each of the roles, pls include the associated Actor object
                                                  ThenInclude(role => role.Actor);

            foreach (var movie in moviesWithRatingsRolesAndActors)
            {
                if (movie.Rating == null)
                {
                    Console.WriteLine($"Movie {movie.Title} - has no rating");
                }
                else
                {
                    Console.WriteLine($"There is a movie named {movie.Title} - {movie.Rating.Description}");
                }
                foreach (var role in movie.Roles)
                {
                    Console.WriteLine($" - {role.CharacterName} played by {role.Actor.FullName}");
                }
            }
        }
    }
}

using System;


namespace CpDatabaseAccess
{
    /// <summary>
    /// DO:
    ///   Install-Package Microsoft.EntityFrameworkCore.SqlServer
    /// </summary>
    class EfCore
    {
        public static void PrintMovies(string connectionString)
        {
            using (var context = new MoviesDbContext(connectionString))
            {
                foreach (var movie in context.Movies)
                {
                    Console.WriteLine($"{movie.ReleaseDate:dd-MM-yyyy}: {movie.Title}");
                }
            }
        }
    }
}

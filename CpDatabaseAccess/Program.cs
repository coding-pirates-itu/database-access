using System;

namespace CpDatabaseAccess
{
    class Program
    {
        const string ConnectionString = @"Data Source=NITRO-MC;Database=Movies;Integrated Security=True";


        static void Main(string[] args)
        {
            //Console.WriteLine(Figgle.FiggleFonts.Fraktur.Render("Hello, EFCore!"));
            //OdbcDirect.PrintMovies(ConnectionString);
            //OdbcEntities.PrintMoviesSorted(ConnectionString);
            EfCore.PrintMovies(ConnectionString);
            Console.WriteLine("End");
        }
    }
}

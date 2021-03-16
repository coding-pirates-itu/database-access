namespace CpDatabaseAccess
{
    class Program
    {
        const string ConnetionString = @"Data Source=NITRO-MC;Database=Movies;Integrated Security=True";


        static void Main(string[] args)
        {
            OdbcDirect.PrintMovies(ConnetionString);
            //OdbcEntities.PrintMoviesSorted(ConnetionString);
            //EfCore.PrintMovies(ConnetionString);
        }
    }
}

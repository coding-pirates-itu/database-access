using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace CpDatabaseAccess
{
    class OdbcEntities
    {
        public static void PrintMoviesSorted(string connectionString)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Title, ReleaseDate, Slogan, Link, StudioId, CertificationId FROM Movies";

            var list = new List<MovieEntity>();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var movie = new MovieEntity
                {
                    Title = reader.GetString(0),
                    ReleaseDate = reader.GetDateTime(1),
                    Slogan = reader.GetString(2),
                    Link = reader.GetString(3),
                    StudioId = reader.GetInt32(4),
                    CertificationId = reader.GetInt32(5)
                };
                list.Add(movie);
            }

            foreach (var movie in list.OrderBy(m => m.ReleaseDate))
            {
                Console.WriteLine($"{movie.ReleaseDate:dd-MM-yyyy}: {movie.Title}");
            }
        }
    }
}

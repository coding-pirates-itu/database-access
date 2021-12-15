using System;
using System.Data.SqlClient;


namespace CpDatabaseAccess
{
    internal class OdbcDirect
    {
        public static void PrintMovies(string connectionString)
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Title, ReleaseDate, Slogan, Link, StudioId, CertificationId FROM Movies";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var title = reader.GetString(0);
                    var released = reader.GetDateTime(1);
                    Console.WriteLine($"{released:dd-MM-yyyy}: {title}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Some error {ex.GetType().Name}: {ex.Message}");
            }
        }
    }
}

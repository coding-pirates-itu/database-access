using Microsoft.EntityFrameworkCore;


namespace CpDatabaseAccess
{
    class MoviesDbContext : DbContext
    {
        private readonly string mConnectionString;

        public MoviesDbContext(string connectionString)
        {
            mConnectionString = connectionString;
        }


        public DbSet<MovieEntity> Movies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(mConnectionString);
        }
    }
}

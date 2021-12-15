using System;
using Microsoft.EntityFrameworkCore;


namespace CpDatabaseAccess
{
    class MoviesDbContext : DbContext
    {
        private readonly string mConnectionString;


        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<TicketEntity> Tickets { get; set; }


        public MoviesDbContext(string connectionString)
        {
            mConnectionString = connectionString;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(mConnectionString);
        }
    }

    public class TicketEntity
    {
        public int Id { get; set; }

        public DateTime BuyDate { get; set; }

        public int MovieId { get; set; }
    }
}

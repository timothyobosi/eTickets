using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data{

    public class AppDbContext: DbContext
    {
        //define constructor(default) it takes parameteter(DbContext) then pass parameter file name: AppDbContext
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options)
        {

        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
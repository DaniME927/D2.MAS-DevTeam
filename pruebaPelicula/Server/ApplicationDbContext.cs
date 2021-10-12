using pruebaPelicula.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace pruebaPelicula.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Actor> Actor { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Movie> Name { get; set; }
        public DbSet<MovieActor> MovieActor { get; set; }
        public DbSet<MovieCategory> MovieCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>.HasKey(x => new{ x.MovieId, x.ActorId });
            ModuleBuilder.Entity<MovieCategory>.HasKey(x => new{ x.MovieId, x.CategoryId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
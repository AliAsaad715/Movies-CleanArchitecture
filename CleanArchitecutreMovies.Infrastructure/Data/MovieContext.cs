using CleanArchitecutreMovies.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecutreMovies.Infrastructure.Data
{
    public class MovieContext(DbContextOptions<MovieContext> options) : DbContext(options)
    {
        public DbSet<Movie> Movies { get; set; }
    }
}

using CleanArchitecutreMovies.Core.Entities;
using CleanArchitecutreMovies.Core.Repositories;
using CleanArchitecutreMovies.Infrastructure.Data;
using CleanArchitecutreMovies.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecutreMovies.Infrastructure.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieContext movieContext) : base(movieContext) { }

        public async Task<IEnumerable<Movie>> GetMoviesByDirectorName(string directorName)
        {
            return await _movieContext.Movies.Where(m => m.DirectorName == directorName).ToListAsync();
        }
    }
}

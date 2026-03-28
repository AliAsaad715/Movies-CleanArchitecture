using CleanArchitecutreMovies.Core.Entities;
using CleanArchitecutreMovies.Core.Repositories.Base;

namespace CleanArchitecutreMovies.Core.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        //here we can have all custom operations 
        Task<IEnumerable<Movie>> GetMoviesByDirectorName(string directorName);
    }
}

using CleanArchitecutreMovies.Application.Responses;
using MediatR;

namespace CleanArchitecutreMovies.Application.Queries
{
    public class GetMoviesByDirectorNameQuery : IRequest<IEnumerable<MovieResponse>>
    {
        public string DirectorName { get; set; }

        public GetMoviesByDirectorNameQuery(string directorName)
        {
            DirectorName = directorName;
        }
    }
}

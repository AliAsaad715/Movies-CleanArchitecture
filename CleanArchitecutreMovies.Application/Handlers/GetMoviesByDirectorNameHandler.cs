using CleanArchitecutreMovies.Application.Queries;
using CleanArchitecutreMovies.Application.Responses;
using CleanArchitecutreMovies.Core.Repositories;
using MediatR;

namespace CleanArchitecutreMovies.Application.Handlers
{
    public class GetMoviesByDirectorNameHandler : IRequestHandler<GetMoviesByDirectorNameQuery, IEnumerable<MovieResponse>>
    {
        private readonly IMovieRepository _movieRepository;

        public GetMoviesByDirectorNameHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Task<IEnumerable<MovieResponse>> Handle(GetMoviesByDirectorNameQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

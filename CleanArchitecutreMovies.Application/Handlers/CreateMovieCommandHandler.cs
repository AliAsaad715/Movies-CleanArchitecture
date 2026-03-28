using CleanArchitecutreMovies.Application.Commands;
using CleanArchitecutreMovies.Application.Mappers;
using CleanArchitecutreMovies.Application.Responses;
using CleanArchitecutreMovies.Core.Entities;
using CleanArchitecutreMovies.Core.Repositories;
using MediatR;

namespace CleanArchitecutreMovies.Application.Handlers
{
    public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, MovieResponse>
    {
        private readonly IMovieRepository _movieRepository;

        public CreateMovieCommandHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<MovieResponse> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            var movieEntity = MovieMapper.Mapper.Map<Movie>(request);
            if (movieEntity is null)
            {
                throw new ApplicationException("There is an issue with mapping...");
            }

            var newMovie = await _movieRepository.AddAsync(movieEntity);
            var movieResponse = MovieMapper.Mapper.Map<MovieResponse>(newMovie);
            return movieResponse;
        }
    }
}

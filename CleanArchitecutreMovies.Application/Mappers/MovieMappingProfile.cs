using AutoMapper;
using CleanArchitecutreMovies.Application.Commands;
using CleanArchitecutreMovies.Application.Responses;
using CleanArchitecutreMovies.Core.Entities;

namespace CleanArchitecutreMovies.Application.Mappers
{
    public class MovieMappingProfile : Profile
    {
        public MovieMappingProfile()
        {
            CreateMap<Movie, MovieResponse>().ReverseMap();
            CreateMap<Movie, CreateMovieCommand>().ReverseMap();
        }
    }
}

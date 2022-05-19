using AutoMapper;
using MovieCentral.Domain.Entities;
using MovieCentral.Shared.Dtos.Movie;

namespace MovieCentral.Application.MappingProfiles;

public class MovieMappingProfile : Profile
{
    public MovieMappingProfile()
    {
        CreateMap<Movie, MovieDetailedDto>();
        CreateMap<Movie, MovieSimpleDto>();
    }
}

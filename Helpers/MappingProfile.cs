using AutoMapper;
using geosphere_api.DTOs;
using geosphere_api.Models;

namespace geosphere_api.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Place, PlaceDto>();
            CreateMap<Ressource, RessourceDto>();
        }
    }
}

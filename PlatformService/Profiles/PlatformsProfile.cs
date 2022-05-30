using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    // Clasa pentru autoMapper (acel Profile este perluat din using AutoMapper)
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
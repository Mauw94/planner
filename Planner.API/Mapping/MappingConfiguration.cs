using AutoMapper;
using Planner.API.Models;
using Planner.API.Models.DTOs;

namespace Planner.API.Mapping
{
    /// <summary>
    /// Mapping configuration.
    /// </summary>
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<Event, EventDto>().ReverseMap();
        }
    }
}
using AutoMapper;
using Odonto.Shared.DTOs.ServicesDTO;

namespace Odonto.Application.Mappers
{
    public class ServicesMappingProfile : Profile
    {
        public ServicesMappingProfile() 
        {
            CreateMap<ServiceRequestDto, Odonto.Domain.Entities.Services>()
                .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
                .ForMember(x => x.Description, x => x.MapFrom(y => y.Description))
                .ForPath(x => x.AuditInfo.UserCreate, x => x.MapFrom(y => y.UserCreate))
                .ReverseMap();
        }
    }
}

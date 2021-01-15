using AutoMapper;
using Auth_API.Dtos.Tenant;
using Auth_API.Models;

namespace Auth_API.Profiles
{
    public class TenantProfile : Profile
    {
        public TenantProfile()
        {
            // createMap< source , destination >();
            CreateMap<Tenant, TenantReadDto>();
            CreateMap<TenantCreateDto, Tenant>();
            CreateMap<TenantUpdateDto, Tenant>();
        }
    }
}
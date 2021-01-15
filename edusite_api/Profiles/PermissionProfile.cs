using AutoMapper;
using Auth_API.Dtos.Permission;
using Auth_API.Models;

namespace Auth_API.Profiles
{
    public class PermissionProfile : Profile
    {
        public PermissionProfile()
        {
            // createMap< source , destination >();
            CreateMap<Permission, PermissionReadDto>();
            CreateMap<PermissionCreateDto, Permission>();
            CreateMap<PermissionUpdateDto, Permission>();
        }
    }
}
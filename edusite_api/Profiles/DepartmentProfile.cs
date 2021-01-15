using AutoMapper;
using Auth_API.Dtos.Department;
using Auth_API.Models;

namespace Auth_API.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            // createMap< source , destination >();
            CreateMap<Department, DepartmentReadDto>();
            CreateMap<DepartmentCreateDto, Department>();
            CreateMap<DepartmentUpdateDto, Department>();
        }
    }
}
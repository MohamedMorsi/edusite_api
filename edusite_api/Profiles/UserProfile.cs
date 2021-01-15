using AutoMapper;
using Auth_API.Dtos.User;
using Auth_API.Models;

namespace Auth_API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // createMap< source , destination >();
            CreateMap<User, UserReadDto>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();
        }
    }
}
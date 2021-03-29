using AutoMapper;
using Dtos.User;
using Models;

namespace edusite_api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // createMap< source , destination >();
            CreateMap<User, UserReadDto>();
            CreateMap<UserReadDto, User>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();
        }
    }

    //public class RoleProfile : Profile
    //{
    //    public RoleProfile()
    //    {
    //        // createMap< source , destination >();
    //        CreateMap<Role, RoleReadDto>();
    //        CreateMap<RoleCreateDto, Role>();
    //        CreateMap<RoleUpdateDto, Role>();
    //    }
    //}

    //public class CourseProfile : Profile
    //{
    //    public CourseProfile()
    //    {
    //        // createMap< source , destination >();
    //        CreateMap<Course, CourseReadDto>();
    //        CreateMap<CourseCreateDto, Course>();
    //        CreateMap<CourseUpdateDto, Course>();
    //    }
    //}


    //public class StudentProfile : Profile
    //{
    //    public StudentProfile()
    //    {
    //        // createMap< source , destination >();
    //        CreateMap<Student, StudentReadDto>();
    //        CreateMap<StudentCreateDto, Student>();
    //        CreateMap<StudentUpdateDto, Student>();
    //    }
    //}


    //public class TeacherProfile : Profile
    //{
    //    public TeacherProfile()
    //    {
    //        // createMap< source , destination >();
    //        CreateMap<Teacher, TeacherReadDto>();
    //        CreateMap<TeacherCreateDto, Teacher>();
    //        CreateMap<TeacherUpdateDto, Teacher>();
    //    }
    //}

    //public class GradeProfile : Profile
    //{
    //    public GradeProfile()
    //    {
    //        // createMap< source , destination >();
    //        CreateMap<Grade, GradeReadDto>();
    //        CreateMap<GradeCreateDto, Grade>();
    //        CreateMap<GradeUpdateDto, Grade>();
    //    }
    //}


}
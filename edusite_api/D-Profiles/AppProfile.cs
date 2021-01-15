using AutoMapper;
using Dtos.Account;
using Dtos.Course;
using Dtos.Grade;
using Dtos.Role;
using Dtos.Student;
using Dtos.Teacher;
using Models;

namespace edusite_api.Profiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            // createMap< source , destination >();
            CreateMap<Account, AccountReadDto>();
            CreateMap<AccountCreateDto, Account>();
            CreateMap<AccountUpdateDto, Account>();
        }
    }

    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            // createMap< source , destination >();
            CreateMap<Role, RoleReadDto>();
            CreateMap<RoleCreateDto, Role>();
            CreateMap<RoleUpdateDto, Role>();
        }
    }

    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            // createMap< source , destination >();
            CreateMap<Course, CourseReadDto>();
            CreateMap<CourseCreateDto, Course>();
            CreateMap<CourseUpdateDto, Course>();
        }
    }


    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            // createMap< source , destination >();
            CreateMap<Student, StudentReadDto>();
            CreateMap<StudentCreateDto, Student>();
            CreateMap<StudentUpdateDto, Student>();
        }
    }


    public class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            // createMap< source , destination >();
            CreateMap<Teacher, TeacherReadDto>();
            CreateMap<TeacherCreateDto, Teacher>();
            CreateMap<TeacherUpdateDto, Teacher>();
        }
    }

    public class GradeProfile : Profile
    {
        public GradeProfile()
        {
            // createMap< source , destination >();
            CreateMap<Grade, GradeReadDto>();
            CreateMap<GradeCreateDto, Grade>();
            CreateMap<GradeUpdateDto, Grade>();
        }
    }


}
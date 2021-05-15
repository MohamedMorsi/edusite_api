using AutoMapper;
using Dtos.Category;
using Dtos.Course;
using Dtos.Grade;
using Dtos.Plan;
using Dtos.Student;
using Dtos.Teacher;
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

    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            // createMap< source , destination >();
            CreateMap<Category, CategoryReadDto>();
            CreateMap<CategoryCreateDto, Category>();
            CreateMap<CategoryUpdateDto, Category>();
        }
    }

    public class PlanProfile : Profile
    {
        public PlanProfile()
        {
            // createMap< source , destination >();
            CreateMap<Plan, PlanReadDto>();
            CreateMap<PlanCreateDto, Plan>();
            CreateMap<PlanUpdateDto, Plan>();
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
}
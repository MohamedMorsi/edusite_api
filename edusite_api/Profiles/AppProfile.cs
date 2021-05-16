using AutoMapper;
using Dtos.Category;
using Dtos.Course;
using Dtos.Grade;
using Dtos.Plan;
using Dtos.Student;
using Dtos.StudentsCourses;
using Dtos.Teacher;
using Dtos.TeachersCourses;
using Dtos.TeachersGrades;
using Dtos.TeachersStudents;
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
            CreateMap<CourseReadDto, Course>();
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
            CreateMap<GradeReadDto, Grade>();
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
            CreateMap<CategoryReadDto, Category>();
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
            CreateMap<PlanReadDto, Plan>();
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
            CreateMap<TeacherReadDto, Teacher>();
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
            CreateMap<StudentReadDto, Student>();
            CreateMap<StudentCreateDto, Student>();
            CreateMap<StudentUpdateDto, Student>();
        }
    }

    public class TeachersGradesProfile : Profile
    {
        public TeachersGradesProfile()
        {
            // createMap< source , destination >();
            CreateMap<TeachersGrades, TeachersGradesReadDto>();
            CreateMap<TeachersGradesReadDto, TeachersGrades>();
            CreateMap<TeachersGradesCreateDto, TeachersGrades>();
            CreateMap<TeachersGradesUpdateDto, TeachersGrades>();
        }
    }

    public class TeachersCoursesProfile : Profile
    {
        public TeachersCoursesProfile()
        {
            // createMap< source , destination >();
            CreateMap<TeachersCourses, TeachersCoursesReadDto>();
            CreateMap<TeachersCoursesReadDto, TeachersCourses>();
            CreateMap<TeachersCoursesCreateDto, TeachersCourses>();
            CreateMap<TeachersCoursesUpdateDto, TeachersCourses>();
        }
    }

    public class TeachersStudentsProfile : Profile
    {
        public TeachersStudentsProfile()
        {
            // createMap< source , destination >();
            CreateMap<TeachersStudents, TeachersStudentsReadDto>();
            CreateMap<TeachersStudentsReadDto, TeachersStudents>();
            CreateMap<TeachersStudentsCreateDto, TeachersStudents>();
            CreateMap<TeachersStudentsUpdateDto, TeachersStudents>();
        }
    }

    public class StudentsCoursesProfile : Profile
    {
        public StudentsCoursesProfile()
        {
            // createMap< source , destination >();
            CreateMap<StudentsCourses, StudentsCoursesReadDto>();
            CreateMap<StudentsCoursesReadDto, StudentsCourses>();
            CreateMap<StudentsCoursesCreateDto, StudentsCourses>();
            CreateMap<StudentsCoursesUpdateDto, StudentsCourses>();
        }
    }
}
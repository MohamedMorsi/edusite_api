using Models;
using System;
using System.Collections.Generic;

namespace edusite_api.Data.Contract
{
    public interface ICourseRepo
    {
        bool SaveChanges();
        IEnumerable<Course> GetAll();
        Course GetCourseById(int id);
        void CreateCourse(Course s);
        void UpdateCourse(Course s);
        void DeleteCourse(Course s);

    }
}
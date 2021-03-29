using System;
using System.Collections.Generic;
using System.Linq;
using edusite_api.Data;
using edusite_api.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Models;

namespace edusite_api.Repository
{
    public class CourseRepo : ICourseRepo
    {
        private readonly DataContext _ctx;

        public CourseRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateCourse(Course s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            s.CreatedDate = DateTime.Now;
            _ctx.Courses.Add(s);
        }

        public void DeleteCourse(Course s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Courses.Remove(s);
        }

        public IEnumerable<Course> GetAll()
        {
            return _ctx.Courses.ToList();
        }

        public Course GetCourseById(int id)
        {
            return _ctx.Courses.FirstOrDefault(s => s.CourseId == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateCourse(Course s)
        {
            //nothing
        }

    }
}
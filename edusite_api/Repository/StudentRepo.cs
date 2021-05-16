using System;
using System.Collections.Generic;
using System.Linq;
using edusite_api.Data;
using edusite_api.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Models;

namespace edusite_api.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly DataContext _ctx;

        public StudentRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateStudent(Student s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            s.CreatedDate = DateTime.Now;
            _ctx.Students.Add(s);
        }

        public void DeleteStudent(Student s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Students.Remove(s);
        }

        public IEnumerable<Student> GetAll()
        {
            return _ctx.Students
                 .Include(a => a.StudentsCourses)
                .Include(a => a.TeachersStudents)
                .Include(a => a.Grade)
                .ToList();
        }

        public Student GetStudentById(int id)
        {
            return _ctx.Students
                .Include(a => a.StudentsCourses)
                .Include(a => a.TeachersStudents)
                .Include(a => a.Grade)
                .FirstOrDefault(s => s.StudentId == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateStudent(Student s)
        {
            _ctx.Update(s);
        }

    }
}
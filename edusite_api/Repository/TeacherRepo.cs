using System;
using System.Collections.Generic;
using System.Linq;
using edusite_api.Data;
using edusite_api.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Models;

namespace edusite_api.Repository
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly DataContext _ctx;

        public TeacherRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateTeacher(Teacher s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            s.CreatedDate = DateTime.Now;
            _ctx.Teachers.Add(s);
        }

        public void DeleteTeacher(Teacher s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Teachers.Remove(s);
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _ctx.Teachers.ToList();
        }

        public Teacher GetTeacherById(int id)
        {
            return _ctx.Teachers.FirstOrDefault(s => s.TeacherId == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateTeacher(Teacher s)
        {
            //nothing
        }

    }
}
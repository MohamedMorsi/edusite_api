using System;
using System.Collections.Generic;
using System.Linq;
using edusite_api.Data;
using edusite_api.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Models;

namespace edusite_api.Repository
{
    public class GradeRepo : IGradeRepo
    {
        private readonly DataContext _ctx;

        public GradeRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateGrade(Grade s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            s.CreatedDate = DateTime.Now;
            _ctx.Grades.Add(s);
        }

        public void DeleteGrade(Grade s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Grades.Remove(s);
        }

        public IEnumerable<Grade> GetAll()
        {
            return _ctx.Grades.Include(t => t.Courses).ToList();
        }

        public Grade GetGradeById(int id)
        {
            return _ctx.Grades.Include(t => t.Courses).FirstOrDefault(s => s.Id == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateGrade(Grade s)
        {
            _ctx.Update(s);
        }

    }
}
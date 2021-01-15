using System;
using System.Collections.Generic;
using System.Linq;
using Auth_API.Data.Contract;
using Auth_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth_API.Data.Repository
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly DataContext _ctx;

        public DepartmentRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateDepartment(Department s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            s.CreatedDate = DateTime.Now;
            _ctx.Departments.Add(s);
        }

        public void DeleteDepartment(Department s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Departments.Remove(s);
        }

        public IEnumerable<Department> GetAll()
        {
            return _ctx.Departments.Include(a => a.Tenant).ToList();
        }

        public Department GetDepartmentById(Guid id)
        {
            return _ctx.Departments.Include(a => a.Tenant).FirstOrDefault(s => s.DepartmentId == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateDepartment(Department s)
        {
            //nothing
        }
    }
}
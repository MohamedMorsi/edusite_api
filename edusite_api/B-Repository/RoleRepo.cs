using System;
using System.Collections.Generic;
using System.Linq;
using edusite_api.Data;
using edusite_api.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Models;

namespace edusite_api.Repository
{
    public class RoleRepo : IRoleRepo
    {
        private readonly DataContext _ctx;

        public RoleRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateRole(Role s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            s.CreatedDate = DateTime.Now;
            _ctx.Roles.Add(s);
        }

        public void DeleteRole(Role s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Roles.Remove(s);
        }

        public IEnumerable<Role> GetAll()
        {
            return _ctx.Roles.ToList();
        }

        public Role GetRoleById(int id)
        {
            return _ctx.Roles.FirstOrDefault(s => s.RoleId == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateRole(Role s)
        {
            //nothing
        }

    }
}
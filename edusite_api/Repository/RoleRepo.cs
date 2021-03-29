using System;
using System.Collections.Generic;
using System.Linq;
using Auth_API.Data.Contract;
using edusite_api.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Auth_API.Data.Repository
{
    public class RoleRepo : IRoleRepo
    {
        private readonly DataContext _ctx;

        public RoleRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        //public void CreateRole(Role s)
        //{
        //    if (s == null)
        //    {
        //        throw new ArgumentNullException(nameof(s));
        //    }
        //    //s.CreatedDate = DateTime.Now;
        //    _ctx.Roles.Add(s);
        //}

        //public void DeleteRole(Role s)
        //{
        //    if (s == null)
        //    {
        //        throw new ArgumentNullException(nameof(s));
        //    }
        //    _ctx.Roles.Remove(s);
        //}

        public IEnumerable<Role> GetAll()
        {
            return _ctx.Roles.ToList();
        }
        public Role GetRoleByName(string Name)
        {
            return _ctx.Roles.FirstOrDefault(s => s.Name == Name);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        //public Role GetRoleById(Guid id)
        //{
        //    return _ctx.Roles.FirstOrDefault(s => s.Id == id.ToString());
        //}


        //public void UpdateRole(Role s)
        //{
        //    //nothing
        //}

        //public Role GetRoleByRolenameAndPassword(string Rolename, string password)
        //{
        //    return _ctx.Roles.Where(a => a.RoleName == Rolename /*&& a.Password == password*/ && a.IsActive == true)
        //        .FirstOrDefault();
        //}
    }
}
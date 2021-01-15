using System;
using System.Collections.Generic;
using System.Linq;
using Auth_API.Data.Contract;
using Auth_API.Models;

namespace Auth_API.Data.Repository
{
    public class PermissionRepo : IPermissionRepo
    {
        private readonly DataContext _ctx;

        public PermissionRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreatePermission(Permission s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            s.CreatedDate = DateTime.Now;
            _ctx.Permissions.Add(s);
        }

        public void DeletePermission(Permission s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Permissions.Remove(s);
        }

        public IEnumerable<Permission> GetAll()
        {
            return _ctx.Permissions.ToList();
        }

        public Permission GetPermissionById(Guid id)
        {
            return _ctx.Permissions.FirstOrDefault(s => s.PermissionId == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdatePermission(Permission s)
        {
            //nothing
        }
    }
}
using System;
using System.Collections.Generic;
using Auth_API.Models;

namespace Auth_API.Data.Contract
{
    public interface IPermissionRepo
    {
        bool SaveChanges();
        IEnumerable<Permission> GetAll();
        Permission GetPermissionById(Guid id);
        void CreatePermission(Permission s);
        void UpdatePermission(Permission s);
        void DeletePermission(Permission s);

    }
}
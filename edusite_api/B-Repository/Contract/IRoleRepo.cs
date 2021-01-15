using Models;
using System;
using System.Collections.Generic;

namespace edusite_api.Data.Contract
{
    public interface IRoleRepo
    {
        bool SaveChanges();
        IEnumerable<Role> GetAll();
        Role GetRoleById(int id);
        void CreateRole(Role s);
        void UpdateRole(Role s);
        void DeleteRole(Role s);

    }
}
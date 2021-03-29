using Models;
using System;
using System.Collections.Generic;

namespace Auth_API.Data.Contract
{
    public interface IRoleRepo
    {
        bool SaveChanges();
        IEnumerable<Role> GetAll();
        Role GetRoleByName(string Name);
        //Role GetRoleById(Guid id);
        //void CreateRole(Role s);
        //void UpdateRole(Role s);
        //void DeleteRole(Role s);
        //Role GetRoleByRolenameAndPassword(string Rolename, string password);

    }
}
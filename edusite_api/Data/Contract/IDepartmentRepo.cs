using System;
using System.Collections.Generic;
using Auth_API.Models;

namespace Auth_API.Data.Contract
{
    public interface IDepartmentRepo
    {
        bool SaveChanges();
        IEnumerable<Department> GetAll();
        Department GetDepartmentById(Guid id);
        void CreateDepartment(Department s);
        void UpdateDepartment(Department s);
        void DeleteDepartment(Department s);

    }
}
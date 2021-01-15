using Models;
using System;
using System.Collections.Generic;

namespace edusite_api.Data.Contract
{
    public interface ITeacherRepo
    {
        bool SaveChanges();
        IEnumerable<Teacher> GetAll();
        Teacher GetTeacherById(int id);
        void CreateTeacher(Teacher s);
        void UpdateTeacher(Teacher s);
        void DeleteTeacher(Teacher s);

    }
}
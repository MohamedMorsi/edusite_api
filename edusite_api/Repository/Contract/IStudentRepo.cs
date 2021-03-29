using Models;
using System;
using System.Collections.Generic;

namespace edusite_api.Data.Contract
{
    public interface IStudentRepo
    {
        bool SaveChanges();
        IEnumerable<Student> GetAll();
        Student GetStudentById(int id);
        void CreateStudent(Student s);
        void UpdateStudent(Student s);
        void DeleteStudent(Student s);

    }
}
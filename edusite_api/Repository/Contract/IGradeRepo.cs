using Models;
using System;
using System.Collections.Generic;

namespace edusite_api.Data.Contract
{
    public interface IGradeRepo
    {
        bool SaveChanges();
        IEnumerable<Grade> GetAll();
        Grade GetGradeById(int id);
        void CreateGrade(Grade s);
        void UpdateGrade(Grade s);
        void DeleteGrade(Grade s);

    }
}
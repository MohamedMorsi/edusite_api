using Models;
using System;
using System.Collections.Generic;

namespace edusite_api.Data.Contract
{
    public interface IPlanRepo
    {
        bool SaveChanges();
        IEnumerable<Plan> GetAll();
        Plan GetPlanById(int id);
        void CreatePlan(Plan s);
        void UpdatePlan(Plan s);
        void DeletePlan(Plan s);

    }
}
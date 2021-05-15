using System;
using System.Collections.Generic;
using System.Linq;
using edusite_api.Data;
using edusite_api.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Models;

namespace edusite_api.Repository
{
    public class PlanRepo : IPlanRepo
    {
        private readonly DataContext _ctx;

        public PlanRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreatePlan(Plan s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Plans.Add(s);
        }

        public void DeletePlan(Plan s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Plans.Remove(s);
        }

        public IEnumerable<Plan> GetAll()
        {
            return _ctx.Plans.ToList();
        }

        public Plan GetPlanById(int id)
        {
            return _ctx.Plans.FirstOrDefault(s => s.Id == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdatePlan(Plan s)
        {
            //nothing
            _ctx.Update(s);
        }

    }
}
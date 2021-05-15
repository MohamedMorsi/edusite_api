using System;
using System.Collections.Generic;
using System.Linq;
using edusite_api.Data;
using edusite_api.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Models;

namespace edusite_api.Repository
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly DataContext _ctx;

        public CategoryRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateCategory(Category s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Categories.Add(s);
        }

        public void DeleteCategory(Category s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Categories.Remove(s);
        }

        public IEnumerable<Category> GetAll()
        {
            return _ctx.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _ctx.Categories.FirstOrDefault(s => s.Id == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateCategory(Category s)
        {
            //nothing
            _ctx.Update(s);
        }

    }
}
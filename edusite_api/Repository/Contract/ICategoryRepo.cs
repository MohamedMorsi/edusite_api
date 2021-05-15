using Models;
using System;
using System.Collections.Generic;

namespace edusite_api.Data.Contract
{
    public interface ICategoryRepo
    {
        bool SaveChanges();
        IEnumerable<Category> GetAll();
        Category GetCategoryById(int id);
        void CreateCategory(Category s);
        void UpdateCategory(Category s);
        void DeleteCategory(Category s);

    }
}
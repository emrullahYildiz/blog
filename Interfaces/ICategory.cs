

using System.Collections.Generic;
using blog.Models;

namespace blog.Interfaces{
    public interface ICategory
    {
        List<Category> getCategories();

        void AddCategory(string categoryName);
    }
}
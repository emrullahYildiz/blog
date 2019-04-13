using System.Collections.Generic;
using System.Linq;
using blog.Interfaces;
using blog.Models;

namespace blog.Implementers{
    public class CategoryContext : ICategory
    {
        private readonly DatabaseContext context;
        public CategoryContext(DatabaseContext context){
            this.context = context;
        }

        public void AddCategory(string categoryName)
        {
            Category category = new Category{
                CategoryName = categoryName,
                CategorySequance = -1 // This will remove
            };
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public List<Category> getCategories()
        {
            List<Category> categories = context.Categories.ToList();
            return categories;
        }
    }
}
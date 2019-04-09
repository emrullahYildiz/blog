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

        public List<Category> getCategories()
        {
            List<Category> categories = context.Categories.ToList();
            return categories;
        }
    }
}
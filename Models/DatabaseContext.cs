
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace blog.Models{
    public class DatabaseContext:DbContext{
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options){

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}
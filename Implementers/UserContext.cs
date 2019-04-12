
using System.Linq;
using blog.Interfaces;
using blog.Models;

namespace blog.Implementers{
    public class UserContext : IUser
    {
        private readonly DatabaseContext databaseContext;
        public UserContext(DatabaseContext databaseContext){
            this.databaseContext = databaseContext;
        }
        public bool checkUser(string userName, string userPassword)
        {
            AdminUser adminUser = databaseContext.AdminUsers
                                 .SingleOrDefault(q => q.UserName == userName 
                                                    && q.UserPassword == userPassword);
            return adminUser != null ? true : false;
        }
    }
}
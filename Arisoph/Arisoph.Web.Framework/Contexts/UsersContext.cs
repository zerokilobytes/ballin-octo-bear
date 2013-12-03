using Arisoph.DAL.DomainObject;
using Arisoph.DAL.DomainObject.Domain;
using System;
using System.Linq;
namespace Arisoph.Web.Framework
{
    public class UsersContext : IDisposable
    {
        //public DbSet<User> Users { get; set; }

        // Helper methods. User can also directly access "Users" property
        public void AddUser(User user)
        {
            UserRepository rep = new UserRepository();
            rep.Add(user);
        }

        public User GetUser(string userName)
        {
            return null;
            // var user = Users.SingleOrDefault(u => u.UserName == userName);
            // return user;
        }

        public User GetUser(string userName, string password)
        {
            UserRepository rep = new UserRepository();
            var user = rep.GetUser(userName, password);
            return user;
        }

        public void Dispose()
        {

        }
    }
}

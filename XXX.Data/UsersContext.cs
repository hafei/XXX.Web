using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using XXX.Models;

namespace XXX.Data
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("UsersContext")
        {

        }
        public DbSet<User> Users { get; set; }

        // Helper methods. User can also directly access "Users" property
        public void AddUser(User user)
        {
            Users.Add(user);
            SaveChanges();
        }

        public User GetUser(string userName)
        {
            var user = Users.SingleOrDefault(u => u.UserName == userName);
            return user;
        }

        public User GetUser(string userName, string password)
        {
            var user = Users.SingleOrDefault(u => u.UserName == userName && u.Password == password);
            return user;
        }
    }
}
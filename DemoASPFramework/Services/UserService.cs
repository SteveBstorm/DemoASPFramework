using DemoASPFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoASPFramework.Services
{
    public class UserService
    {
        public List<User> userList { get; set; }
        public UserService()
        {
            userList = new List<User>()
            {
                new User{ Email = "admin@test.com", Password ="test1234", IsAdmin = true},
                new User{ Email = "test@test.com", Password ="test1234", IsAdmin = false},
            };
        }

        public User Login(string email, string password)
        {
            User connectedUser = userList.Where(u => u.Email == email && u.Password == password).FirstOrDefault();

            if (connectedUser is null)
                throw new NullReferenceException();

            return connectedUser;
        }
    }
}
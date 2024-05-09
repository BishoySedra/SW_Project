using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_Management_System.Model
{
    internal class User
    {
        public int Id ;
        public string Email;
        public string Username;
        public string Password;
        public string Role;//ADMIN,AUTHOR,READER
        public User(string email, string username, string password, string role)
        {
            Email = email;
            Username = username;
            Password = password;
            Role = role;
        }
    }
}

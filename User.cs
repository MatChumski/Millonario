using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millonario
{
    internal class User
    {
        private string username;
        private string password;
        private string email;

        public User(string newUsername, string newPassword, string newEmail)
        {
            username = newUsername;
            password = newPassword;
            email = newEmail;
        }

        public string Username
        {
            get { 
                return username; 
            }
            set { 
                username = value; 
            }
        }

        public string Password 
        {
            get { 
                return password; 
            }
            set { 
                password = value; 
            }
        }

        public string Email
            {
            get { 
                return email; 
            }
            set { 
                email = value; 
            }
        }

        
    }
}

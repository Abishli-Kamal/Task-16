using System;
using System.Collections.Generic;
using System.Text;

namespace task_modifier
{
    internal class User
    {
        protected string _username;
        protected string _password;

        public User(string _username, string _password)
        {
            this.Username = _username;
            this.Password = _password;
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                if (value.Length>8)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password try again");
                }

            }

        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length >6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Username try again");
                }
            }
        }

    }
    
}

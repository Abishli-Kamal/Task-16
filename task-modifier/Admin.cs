using System;
using System.Collections.Generic;
using System.Text;

namespace task_modifier
{
    internal class Admin : User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(bool isSuperAdmin, string section, string _username, string _password) : base(_username, _password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }
        public void All()
        {
            if (_password == Password && _username == Username)
            {
                Console.WriteLine($"Username:{_username} Password: {_password} IsSuperAdmin:{IsSuperAdmin} Section:{Section}");
            }

        }
    }
}

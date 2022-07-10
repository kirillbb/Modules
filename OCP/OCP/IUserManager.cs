using System;
using System.Collections.Generic;
using System.Text;
using OCP.Domain;

namespace OCP
{
    internal interface IUserManager
    {
        public User[] GetUsers();
    }
}

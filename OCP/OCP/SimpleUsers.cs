using OCP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP
{
    internal class SimpleUsers : UserManager
    {
        public override User[] GetUsers() => userStore.Users.Where(u => u.Role != Roles.Admin && !u.IsPremiumUser).ToArray();
    }
}

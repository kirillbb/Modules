using OCP.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    internal class Admins : UserManager
    {
        public override User[] GetUsers() => userStore.Users.Where(u => u.Role == Roles.Admin).ToArray();
    }
}

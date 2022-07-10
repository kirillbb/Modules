using OCP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP
{
    internal class PremiumUsers : UserManager
    {
        public override User[] GetUsers() => userStore.Users.Where(u => u.IsPremiumUser && u.Subscription.IsActive).ToArray();
    }
}

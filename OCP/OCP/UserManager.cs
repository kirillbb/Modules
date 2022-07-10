using OCP.Domain;
using System;
using System.Linq;

namespace OCP
{
    public abstract class UserManager : IUserManager
    {
        protected readonly IUserStore userStore = new UserStore();

        public abstract User[] GetUsers();
    }
}

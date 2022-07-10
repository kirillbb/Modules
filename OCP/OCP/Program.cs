using System.Linq;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleUsers = new SimpleUsers();

            var users = simpleUsers.GetUsers(); 
        }
    }
}

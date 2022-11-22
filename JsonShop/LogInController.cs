using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal class LogInController : ILogInController
    {
        public int WriteId()
        {
            Console.WriteLine("Write your ID");
            var Id = Convert.ToInt32(Console.ReadLine());
            return Id;
        }

        public string WritePassword()
        {
            Console.WriteLine("Write your password");
            var password = Console.ReadLine();
            return password;
        }

        public void LogIn(int id, string password, List<ICustomer> customerList, ICustomer _loggedCustomer)
        {
            var user = customerList.Find(c => c.Id == id && c.Password == password);
            if (user is ICustomer)
            {

                _loggedCustomer = user;
                Console.WriteLine($"You are logged in as {_loggedCustomer.Name}. Welcome!");
            }
            else
            {
                Console.WriteLine("Wrong Password or Id");
            }
        }
    }
}

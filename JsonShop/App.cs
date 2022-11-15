using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal class App
    {
        private List<ICustomer> customerList = new List<ICustomer>()
        {
            new Customer("Frank", 2000),
        };

        private List<IItem> itemList = new List<IItem>()
        {
            new Item(25, "Socks"),
        };

        public void  RunApp()
        {

        }

        public void Greting()
        {
            Console.WriteLine("Welcome to our Online Shop!");
            Console.WriteLine("1 - logIn");
            Console.WriteLine("2 - Create User");
            Console.ReadLine();
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal class App
    {
       
        private IOnlineShop _onlineShop;
        private ICustomer _loggedCustomer;

        public App(IOnlineShop onlineShop)
        {
            _onlineShop = onlineShop;
        }

        

        private List<ICustomer> customerList = new List<ICustomer>()
        {
            new Customer("Frank", 2000, "123abcd",1111),
            new Customer("Per", 2200, "321dcba",2222),
            new Customer("Arne", 1000, "213cdab",3333),
            new Customer("Peder", 12000, "543ads",4444),
            new Customer("Anders", 223000, "abcdd123", 5555),
            new Customer("Bjarne", 5000,  "22ss", 6666),
            new Customer("Ole", 20,  "666saints", 7777),
            new Customer("Silje", 800,  "hello", 8888),
        };

        private List<IItem> itemList = new List<IItem>()
        {
            new Item(25, "Socks"),
            new Item(55, "Shirt"),
            new Item(35, "Baseball"),
            new Item(105, "Gloves"),
            new Item(207, "Nike"),
            new Item(300, "Game"),
            new Item(5, "Nail polish"),
            new Item(800, "Cowboy boots"),
            new Item(225, "Caps"),
            new Item(5000, "Nintendo"),
            new Item(2500, "Pokemon ball"),
        };

        public void  RunApp()
        {
            Greeting();
            CreateOrLogin(ValidateGreeting());
        
        }
        

        public void Greeting()
        {
            Console.WriteLine("Welcome to our Online Shop!");
            Console.WriteLine("1 - logIn");
            Console.WriteLine("2 - Create User");            
        }

        public string ValidateGreeting()
        {

            while (true)
            {
                var input = Console.ReadLine();

                if(input == "1")
                {
                    return "1";
                }
                else if( input == "2")
                {
                    return "2";
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
            }
        }
        
        public void CreateOrLogin(string OneOrTwo)
        {
            if(OneOrTwo == "1")
            {
                LoginInfo();
            }
            else
            {
                CreateUserInfo();
            }
        }



        public void LoginInfo()
        {
            Console.WriteLine("Write your ID");
            var Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your password");
            var password = Console.ReadLine();
            LogIn(Id,password);
        }

        public void LogIn(int id, string password)
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

        public void CreateUserInfo()
        {
            Console.WriteLine("Write your Name");
            var name = Console.ReadLine();
            Console.WriteLine("Write your password");
            var password = Console.ReadLine();
            Console.WriteLine("Write how much will you put on your account");

            var Id = GenerateId();

            var money = Convert.ToInt32(Console.ReadLine());
            Customer c = new Customer(name, money, password, Id);
            customerList.Add(c);
           
            Console.WriteLine($"Welcome, your User was created , this is your id {c.Id}! Remember, you will need to login!");

        }


        public int GenerateId()
        {
            Random random = new Random();
            var r = random.Next(1, 10000);
            var r2 = random.Next(10000, 20000);
            var Id = r + r2;
            return Id;
        }
    }
}

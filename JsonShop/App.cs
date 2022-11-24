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
        private ICreateUserController _createUser;
        private ILogInController _logIn;
        private List<ICustomer> customerList { get; set; } 
        private List<IItem> itemList { get; set; } 
        public App(IOnlineShop onlineShop, ICreateUserController createUserController, ILogInController login, List<ICustomer> customers, List<IItem> items)
        {
            _onlineShop = onlineShop;
            _createUser = createUserController;
            _logIn = login;
            customerList=customers;
            itemList = items;
        }

        public void  RunApp()
        {
            Greeting();
            CreateOrLogin(ValidateGreeting());

            WelcomToShop(_loggedCustomer);
            Console.WriteLine(FilterItems(ValidateWelcomeToShop()));
        
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
                GetLoginInfo();
            }
            else
            {
                GetNewUser();
            }
        }



        public void GetLoginInfo()
        {
            var Id = _logIn.WriteId();
            var password = _logIn.WritePassword();
            _logIn.LogIn(Id, password, customerList, _loggedCustomer);
        }


        public void GetNewUser()
        {
            _loggedCustomer = _createUser.CreateUser();
            customerList.Add(_loggedCustomer);
   
            Console.WriteLine($"Welcome {_loggedCustomer.Name}, your User was created , this is your id {_loggedCustomer.Id}! Remember, you will need to login!");

        }

        public void WelcomToShop(ICustomer _loggedCustomer) // refactor to Shop
        {
            Console.WriteLine($"{_loggedCustomer.Name} you have {_loggedCustomer.Money} on your account");
            Console.WriteLine("We have items on our shop that fit the amount on your account, you want see only those intems or all items?");
            Console.WriteLine($"1- Items that I can afford");
            Console.WriteLine($"2- All items");
        }

        public int ValidateWelcomeToShop()
        {
            while(true)
            {
                var input = Console.ReadLine();
                if (input == "1") return 1;
                else if (input == "2") return 2;
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
            }
        }

        public string FilterItems(int input)
        {
            while (true)
            {
                if(input == 1)
                {
                    
                    var affordableItems = itemList.FindAll(CheckIItemIsShop);
                    ShowItems(affordableItems);
                    return validateBuyInput(affordableItems);
                }
                else
                {
                    ShowItems(itemList);
                    return validateBuyInput(itemList);
                }
            }

        }

        public bool CheckIItemIsShop(IItem i)
        {
            if (i is ShopItem sp)
            {
                return sp.PriceToCustomer <= _loggedCustomer.Money;
            }
            else return false;
        }

        public void ShowItems(List<IItem> items)
        {
            for(var i = 0; i < items.Count; i++)
            {
                if(items[i] is ShopItem sp)
                {
                    Console.WriteLine($"{i} - {sp.DescriptionToCustomer()}");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("To choose the Item u want to buy, press the number infront");

        }

        public string validateBuyInput(List<IItem> items)
        {
            while(true)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                if(input <= items.Count)
                {
                    if (items[input] is ShopItem sp) return sp.Buy(_loggedCustomer);
                   
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                
            }
        }






        
    }
}

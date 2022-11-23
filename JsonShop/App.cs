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
        private List<ISellItem> itemList { get; set; } 
        public App(IOnlineShop onlineShop, ICreateUserController createUserController, ILogInController login, List<ICustomer> customers, List<ISellItem> items)
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
            var newUser = _createUser.CreateUser();
            customerList.Add(newUser);   
            Console.WriteLine($"Welcome {newUser.Name}, your User was created , this is your id {newUser.Id}! Remember, you will need to login!");

        }


        
    }
}

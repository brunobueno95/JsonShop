using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal class CreateUserController : ICreateUserController
    {
        private ICustomer _customer;

        public CreateUserController(ICustomer customer)
        {
            _customer = customer;
        }
        public string CreateUserName()
        {
            Console.WriteLine("Write your Name");
            var name = Console.ReadLine();
            _customer.Name =name;

            return name;
        }

        public string CreateUserPassword()
        {
            Console.WriteLine("Write your password");
            var password = Console.ReadLine();
            _customer.MakePassword(password);
            return password;

        }

        public int CreateUserMoney()
        {
            Console.WriteLine("Write how much will you put on your account");
            var money = Convert.ToInt32(Console.ReadLine());
            _customer.MoneyAccount(money);
            return money;
        }

        public int CreateUserGenerateId()
        {
            Random random = new Random();
            var r = random.Next(1, 10000);
            var r2 = random.Next(10000, 20000);
            var Id = r + r2;
            _customer.MakeId(Id);
            return Id;
        }

        public Customer CreateUser()
        {
            var name = CreateUserName();

            var password = CreateUserPassword();
            var money = CreateUserMoney();
            var Id = CreateUserGenerateId();

            
                return (Customer)_customer;
            
            //var newUser = new Customer(name, money, password, Id);
            
            
        }


    }
}

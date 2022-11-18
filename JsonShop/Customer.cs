using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal class Customer :ICustomer
    {
        public string Name { get; set; }
        public List<IItem> ItemsBought { get; set;}

        public int Money { get;  protected set; }

        public int Id { get; protected  set; }

        public string Password { get; protected set; }

        public Customer(string name, int money, string password, int id)
        {
            Name = name;
            Money = money;
            Password = password;
            Id = id;
            //CreateId();
        }
       public void MakePassword(string Input)
        {
            Password = Input;
        }

        public void CreateId()
        {
            Random random = new Random();
            var r = random.Next(1, 10000);
            var r2 = random.Next(10000, 20000);
            Id = r + r2;
        }


        public void Payment(int Pricepaying)
        {
            Money -= Pricepaying;
        }
    }
}

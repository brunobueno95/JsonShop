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

        public int Money { get; private set; }

        public int Id { get; set; }

        private string Password;

        public Customer(string name, int money)
        {
            Name = name;
            Money = money;
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
    }
}

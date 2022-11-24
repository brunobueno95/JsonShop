using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal interface ICustomer
    {
        string Name { get; set; }
        public List<ICustomerItem> ItemsBought { get;  }
        int Id { get;  }
        int Money { get;   }
        string Password { get;   }

        void Payment(int price);
        public void MakePassword(string Input);
        public void MakeId(int Input);
        public void MoneyAccount(int Input);
    }
}

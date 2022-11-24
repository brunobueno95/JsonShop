using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal class CustomerItem : ICustomerItem
    {

        public int PriceToCustomer { get; set; }

        public string Name { get; set; }







        public string DescriptionToCustomer()
        {
            return $"You Bought {Name} and that costed {PriceToCustomer}";
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal class Item : ISellItem
    {
        
        public int PriceToCustomer { get; set; }
        public int PriceToShop { get ; set ; }
        public int AmountInStock { get; set; }
        public bool HaveOnStock { get; set ; }
        public string Description { get; private set; }

        public Item(int priceToCustomer, string description)
        {
            PriceToCustomer= priceToCustomer;
            Description= description;
        }


        
    }
}

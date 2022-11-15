using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal interface ISellItem : IItem
    {
        int PriceToCustomer { get; set; }

        int PriceToShop { get; set; }

        int AmountInStock { get; set; }

        bool HaveOnStock { get; set; }

        string Description { get;}

        


    }
}

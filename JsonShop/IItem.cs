using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal interface IItem
    {
        int PriceToCustomer { get; set; }

        string Description { get;  }
    }
}

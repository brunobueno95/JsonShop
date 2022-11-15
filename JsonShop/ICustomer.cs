using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal interface ICustomer
    {
        int Id { get; set; }
        int Money { get; set; }
    }
}

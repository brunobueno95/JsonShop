using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal class ShopItem : IShopItem
    {
        public int PriceToCustomer { get; set; }
        public int PriceToShop { get;set; }
        public int AmountInStock { get; set; }
        public bool HaveOnStock { get; set; }
        public string Name { get; set; }

        public ShopItem(int priceToCustomer, string name, bool haveonstock, int amountonstock)
        {
            PriceToCustomer = priceToCustomer;
            Name = name;
            HaveOnStock = haveonstock;
            AmountInStock = amountonstock;
            
        }

        public string DescriptionToCustomer()
        {
            return $"{Name} costs {PriceToCustomer}. {GenerateVarHasInStock()}";
        }

        public string Buy(ICustomer loggedCustomer)
        {
            if (loggedCustomer.Money >= PriceToCustomer && HaveOnStock == true)
            {
               
                loggedCustomer.Payment(PriceToCustomer);
                loggedCustomer.ItemsBought.Add((ICustomerItem)this);
                AmountInStock--;
                return $"You bought {Name} :)";
            }
            else
            {
                return $"You dont have enough money on your account to buy {Name}";
            }
            

        }

        public string GenerateVarHasInStock()
        {
            var hasONStock = "out of stock";
            if (HaveOnStock == true)
            {
                hasONStock = Convert.ToString(AmountInStock);
            }
            return hasONStock;
        }
    }

   
    }


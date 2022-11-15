using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonShop
{
    internal class OnlineShop
    {
        public List<ISellItem> AllSellItems { get; set; }  //Json clothes // json med Gadegets

        public int Income { get; private set; }

        public int Expenses { get; private set; }

        public int Profit { get; set; }

        private ICustomer _customer;

        public void FillUpStock(ISellItem ItemNeedingToStock, int AmountOfItemsBuying)
        {
            ItemNeedingToStock.AmountInStock += AmountOfItemsBuying;
            var spending = ItemNeedingToStock.PriceToShop * AmountOfItemsBuying;
            CalculateExpenses(spending);
        }

        public int CalculateProfit(int Income, int Expenses)
        {
            Profit = Income - Expenses;
            return Profit;
        }

        public void SellItem(ISellItem itemToSell )
        {
            itemToSell.AmountInStock--;
            _customer.Money -= itemToSell.PriceToCustomer;
            CalculateIncome(itemToSell.PriceToCustomer);

        }
        public int CalculateIncome(int PriceSoldItem)
        {
            Income += PriceSoldItem ;
            return Income;

        }

        public int CalculateExpenses(int PricePaidToFillStock)
        {
            Expenses += PricePaidToFillStock;
            return Expenses;
        }



    }
}


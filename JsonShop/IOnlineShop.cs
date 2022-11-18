namespace JsonShop
{
    internal interface IOnlineShop
    {
        List<ISellItem> AllSellItems { get; set; }
        int Expenses { get; }
        int Income { get; }
        int Profit { get; set; }

        int CalculateExpenses(int PricePaidToFillStock);
        int CalculateIncome(int PriceSoldItem);
        int CalculateProfit(int Income, int Expenses);
        void FillUpStock(ISellItem ItemNeedingToStock, int AmountOfItemsBuying);
        void SellItem(ISellItem itemToSell);
    }
}
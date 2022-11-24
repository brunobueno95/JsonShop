namespace JsonShop
{
    internal interface IOnlineShop
    {
        List<IShopItem> AllSellItems { get; set; }
        int Expenses { get; }
        int Income { get; }
        int Profit { get; set; }

        int CalculateExpenses(int PricePaidToFillStock);
        int CalculateIncome(int PriceSoldItem);
        int CalculateProfit(int Income, int Expenses);
        void FillUpStock(IShopItem ItemNeedingToStock, int AmountOfItemsBuying);
        void SellItem(IShopItem itemToSell);
    }
}
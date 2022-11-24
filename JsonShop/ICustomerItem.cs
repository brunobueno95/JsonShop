namespace JsonShop
{
    internal interface ICustomerItem :IItem
    {
        string Name { get; set; }
        int PriceToCustomer { get; set; }

        string DescriptionToCustomer();
    }
}
namespace JsonShop
{
    internal class Program
    {
        private static List<IItem> items;
        private static List<ICustomer> customers;
        static void Main(string[] args)
        {
            FillItemsList();
            FillCustomersList();

            App app = new App(new OnlineShop(), new CreateUserController(new Customer()),new LogInController(),customers,items);
            app.RunApp();
        }

        private static void FillItemsList()
        {
            items = new List<IItem>()
        {
            new ShopItem(25, "Socks",true,10),
            new ShopItem(55, "Shirt",true,10),
            new ShopItem(35, "Baseball",true,10),
            new ShopItem(105, "Gloves",true,10),
            new ShopItem(207, "Nike",true,10),
            new ShopItem(300, "Game",true,10),
            new ShopItem(5, "Nail polish",true,10),
            new ShopItem(800, "Cowboy boots",true,10),
            new ShopItem(225, "Caps",true,10),
            new ShopItem(5000, "Nintendo",true,10),
            new ShopItem(2500, "Pokemon ball",true,10),
        };
        }

        private static void FillCustomersList()
        {
            customers = new List<ICustomer>()
        {
            new Customer("Frank", 2000, "123abcd",1111),
            new Customer("Per", 2200, "321dcba",2222),
            new Customer("Arne", 1000, "213cdab",3333),
            new Customer("Peder", 12000, "543ads",4444),
            new Customer("Anders", 223000, "abcdd123", 5555),
            new Customer("Bjarne", 5000,  "22ss", 6666),
            new Customer("Ole", 20,  "666saints", 7777),
            new Customer("Silje", 800,  "hello", 8888),
        };
        }
    }
}
namespace JsonShop
{
    internal class Program
    {
        private static List<ISellItem> items;
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
            items = new List<ISellItem>()
        {
            new Item(25, "Socks"),
            new Item(55, "Shirt"),
            new Item(35, "Baseball"),
            new Item(105, "Gloves"),
            new Item(207, "Nike"),
            new Item(300, "Game"),
            new Item(5, "Nail polish"),
            new Item(800, "Cowboy boots"),
            new Item(225, "Caps"),
            new Item(5000, "Nintendo"),
            new Item(2500, "Pokemon ball"),
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
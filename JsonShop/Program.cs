namespace JsonShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App app = new App(new OnlineShop());
            app.RunApp();
        }
    }
}
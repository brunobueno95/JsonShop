namespace JsonShop
{
    internal interface ILogInController
    {
        void LogIn(int id, string password, List<ICustomer> customerList, ICustomer _loggedCustomer);
        int WriteId();
        string WritePassword();
    }
}
namespace JsonShop
{
    internal interface ICreateUserController
    {
        int CreateUserGenerateId();
        int CreateUserMoney();
        string CreateUserName();
        string CreateUserPassword();
        public ICustomer CreateUser();
    }
}
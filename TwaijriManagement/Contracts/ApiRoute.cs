namespace TwaijriManagement.Contracts
{
    public static class ApiRoute
    {
        public static class CustomerRoute
        {
            public const string Create = "api/Customer/Create";
            public const string Get = "api/Customer/get";
            public const string GetAll = "api/Customer/GetAll";
            public const string Update = "api/Customer/Update";
            public const string Delete = "api/Customer/Delete";
        }
        public static class InvoiceRoute
        {
            public const string Create = "api/Invoice/Create";
            public const string Get = "api/Invoice/Get";
            public const string GetAll = "api/Invoice/GetAll";
            public const string Update = "api/Invoice/Update";
            public const string Delete = "api/Invoice/Delete";

        }

    }
}

namespace CRUDAppusingADO
{
    public static class ConnectionString
    {
        private static string cs = "server=SHARADALUITEL01\\SA; database=CrudADOdb; Trusted_Connection=false; user=sa; password=Softech@123; TrustServerCertificate=true;";
            public static string dbcs { get => cs; }
    }
}

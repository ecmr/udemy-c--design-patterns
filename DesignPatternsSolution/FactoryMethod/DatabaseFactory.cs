namespace FactoryMethod
{
    class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType DatabaseType)
        {
            switch (DatabaseType)
            {
                case FactoryMethod.DatabaseType.OleDb:
                    return new OleDbdatabase();
                case FactoryMethod.DatabaseType.SqlServer:
                default:
                    return new SqlServerDatabase();
            }
        }
    }
}
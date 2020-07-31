using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BuilderPattern
{
    class SqlServerDatabaseBuilder: IDatabaseBuilder
    {
        private Database _Database;

        public SqlServerDatabaseBuilder()
        {
            _Database = new SqlServerDatabase();
        }

        public void BuildConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnectionSting"].ConnectionString;
            _Database.Connection = new SqlConnection(connectionString);
        }

        public void BuildCommand()
        {
            _Database.Command = new SqlCommand();
            _Database.Command.Connection = _Database.Connection;
        }

        public void SetSettings()
        {
            _Database.Command.CommandTimeout = 360;
            _Database.Command.CommandType = CommandType.Text;
        }

        public Database Database
        {
            get { return _Database; }
        }
    }
}
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace FactoryMethod
{
    public class OleDbdatabase : IDatabase
    {
        private IDbConnection _Connection = null;
        private IDbCommand _Command = null;

        public IDbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["OleDBConnectionString"].ConnectionString;
                    _Connection = new OleDbConnection(connectionString);
                }
                return _Connection;
            }
        }

        public IDbCommand Command
        {
            get
            {
                if (_Command == null)
                {
                    _Command = new OleDbCommand();
                    _Command.Connection = (OleDbConnection)Connection;
                }
                return _Command;
            }
        }
    }
}
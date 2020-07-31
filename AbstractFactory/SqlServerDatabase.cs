using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;

namespace AbstractFactory
{
    public class SqlServerDatabase: Database
    {
        private SqlConnection _Connection = null;
        private SqlCommand _Command = null;

        public override DbConnection Connection 
        { 
            get
            {
                if (_Connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnectionSting"].ConnectionString;
                    _Connection = new SqlConnection(connectionString);
                }
                return _Connection;
            }
        }

        public override DbCommand Command
        {
            get
            {
                if (_Command == null)
                {
                    _Command = new SqlCommand();
                    _Command.Connection = _Connection;
                }
                return _Command;
            }
        }
    }
}

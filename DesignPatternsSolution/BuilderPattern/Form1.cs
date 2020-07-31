using System;
using System.Data.Common;
using System.Windows.Forms;

namespace BuilderPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDatabase_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            IDatabaseBuilder builder;

            if (rBtnSqlServer.Checked)
            {
                builder = new SqlServerDatabaseBuilder();
            }
            else
            {
                builder = new OleDbDatabaseBuilder();
            }

            director.Build(builder);
            Database database = builder.Database;
            DbCommand command = database.Command;
            //// now, we can do something, like:
            //command.CommandType = CommandType.Text;
            //command.CommandText = "Minha Query";
            //command.Connection.Open();
            //DbDataReader dbDataReader = command.ExecuteReader();

            //dbDataReader.Close();
            //command.Connection.Close();
        }
    }
}

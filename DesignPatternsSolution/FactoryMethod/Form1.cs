﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDatabase_Click(object sender, EventArgs e)
        {
            IDatabase database;
            DatabaseType databaseType = DatabaseType.SqlServer;
            if(rBtnOleDb.Checked)
                databaseType = DatabaseType.OleDb;
            database = DatabaseFactory.CreateDatabase(databaseType);

            IDbCommand command = database.Command;
            //...

        }
    }
}

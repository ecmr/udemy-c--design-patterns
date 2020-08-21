using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State
{
    public partial class Form1 : Form
    {
        private User user = new User("KW");
        public Form1()
        {
            InitializeComponent();
        }

        private void i_Click(object sender, EventArgs e)
        {
            user.Login();
            txtNextPageToShow.Text = user.NextPage;
        }

        private void btnUpgradeUser_Click(object sender, EventArgs e)
        {
            user.Upgrade();
            txtNextPageToShow.Text = user.NextPage;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            user.Logout();
            txtNextPageToShow.Text = user.NextPage;
        }
    }
}

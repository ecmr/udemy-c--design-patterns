using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor
{
    public partial class Form1 : Form
    {
        private Users Users = new Users();
        private User Greg = new User("Greg", DateTime.Now, 25);
        private User Richard = new User("Richard", DateTime.Now.AddMonths(-6), 42);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Users.Attach(Greg);
            Users.Attach(Richard);
            UpdateStatus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Users.Accept(new ExpirationVisitor());
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            lblGreg.Text = Greg.Name + ": " + Greg.Credits.ToString() + " credits expire " + Greg.ExpirationDate.ToString();
            lblRichard.Text = Richard.Name + ": " + Richard.Credits.ToString() + " credits expire " + Richard.ExpirationDate.ToString();
        }
    }
}

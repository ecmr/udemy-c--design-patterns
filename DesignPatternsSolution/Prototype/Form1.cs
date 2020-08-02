using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Form1 : Form
    {
        User Admin;
        User AdminClone;
        User AdminDeepClone;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Admin = new Admin
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                HomeAddress = new Address
                {
                    Address1 = txtHomeAddress.Text,
                    Address2 = txtHomeAddress2.Text,
                    City = txtHomeCity.Text,
                    State = txtHomeState.Text,
                    Zip = txtHomeZip.Text
                },
                BusinessAddress = new Address
                {
                    Address1 = txtBizAddress.Text,
                    Address2 = txtBizAddress2.Text,
                    City = txtBizCity.Text,
                    State = txtBizState.Text,
                    Zip = txtBizZip.Text
                }

            };

            AdminClone = (User)Admin.Clone();
            AdminDeepClone = Admin.DeepClone();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Admin.FirstName = txtFirstName.Text;
            Admin.LastName = txtLastName.Text;
            Admin.UserName = txtUserName.Text;
            Admin.Password = txtPassword.Text;

            Admin.HomeAddress.Address1 = txtHomeAddress.Text;
            Admin.HomeAddress.Address2 = txtHomeAddress2.Text;
            Admin.HomeAddress.City = txtHomeCity.Text;
            Admin.HomeAddress.State = txtHomeState.Text;
            Admin.HomeAddress.Zip = txtHomeZip.Text;
            
            Admin.BusinessAddress.Address1 = txtBizAddress.Text;
            Admin.BusinessAddress.Address2 = txtBizAddress2.Text;
            Admin.BusinessAddress.City = txtBizCity.Text;
            Admin.BusinessAddress.State = txtBizState.Text;
            Admin.BusinessAddress.Zip = txtBizZip.Text;
        }

        private void btnReadClone_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = AdminClone.FirstName;
            lblLastName.Text = AdminClone.LastName;
            lblUserName.Text = AdminClone.UserName;
            lblPassword.Text = AdminClone.Password;

            lblHomeAddress.Text =  AdminClone.HomeAddress.Address1;
            lblHomeAddress2.Text = AdminClone.HomeAddress.Address2;
            lblHomeCity.Text =  AdminClone.HomeAddress.City;
            lblHomeState.Text = AdminClone.HomeAddress.State;
            lblHomeZip.Text = AdminClone.HomeAddress.Zip;
            
            lblBizAddress.Text = AdminClone.BusinessAddress.Address1;
            lblBizAddress2.Text = AdminClone.BusinessAddress.Address2;
            lblBizCity.Text = AdminClone.BusinessAddress.City;
            lblBizState.Text = AdminClone.BusinessAddress.State;
            lblBizZip.Text = AdminClone.BusinessAddress.Zip;
        }

        private void btnReadDeepClone_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = AdminDeepClone.FirstName;
            lblLastName.Text = AdminDeepClone.LastName;
            lblUserName.Text = AdminDeepClone.UserName;
            lblPassword.Text = AdminDeepClone.Password;
            lblHomeAddress.Text = AdminDeepClone.HomeAddress.Address1;
            lblHomeAddress2.Text = AdminDeepClone.HomeAddress.Address2;
            lblHomeCity.Text = AdminDeepClone.HomeAddress.City;
            lblHomeState.Text = AdminDeepClone.HomeAddress.State;
            lblHomeZip.Text = AdminDeepClone.HomeAddress.Zip;
            lblBizAddress.Text = AdminDeepClone.BusinessAddress.Address1;
            lblBizAddress2.Text = AdminDeepClone.BusinessAddress.Address2;
            lblBizCity.Text = AdminDeepClone.BusinessAddress.City;
            lblBizState.Text = AdminDeepClone.BusinessAddress.State;
            lblBizZip.Text = AdminDeepClone.BusinessAddress.Zip;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = "Edinei";
            txtLastName.Text = "Menezes";
            txtUserName.Text = "edmenezes";
            txtPassword.Text = "";
            txtHomeAddress.Text = "Aricanduva Avenue";
            txtHomeCity.Text = "São Paulo";
            txtHomeState.Text = "SP";
            txtHomeZip.Text = "03951-220";

            txtBizAddress.Text = "Chucry Zaidan Avenue";
            txtBizAddress2.Text = "17 Floor";
            txtBizCity.Text = "São Paulo";
            txtBizState.Text = "SP";
            txtBizZip.Text = "1234-567";

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            if (this.ckbLoyaly.Checked && this.ckbStudent.Checked)
            {
                customer.SetDiscountStrategy(new LoyalStudentDiscount());
            }
            else if(this.ckbLoyaly.Checked)
            {
                customer.SetDiscountStrategy(new StudentDiscount());
            }
            else
            {
                customer.SetDiscountStrategy(new NoDiscount());
            }
            decimal price = customer.ApplyDiscount(this.nupdtotalSale.Value);
            lblFinalPrice.Text = price.ToString("C");
        }
    }
}

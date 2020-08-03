using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.rdo8.CheckedChanged += option_CheckedChanged;
            this.rdo16.CheckedChanged += option_CheckedChanged;
            this.rdo128.CheckedChanged += option_CheckedChanged;
            this.rdo256.CheckedChanged += option_CheckedChanged;
            this.rdo512.CheckedChanged += option_CheckedChanged;

            DisplayPrice();
        }

        private void option_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPrice();
        }

        private void DisplayPrice()
        {
            ComputerBase computer = new ComputerBase()
            {
                Model = "ExtremeXPC"
            };

            ComputerDecorator ramDecorator;
            if (rdo8.Checked)
            {
                ramDecorator = new Memory8Options(computer);
            }
            else
            {
                ramDecorator = new Memory16Options(computer);
            }

            ComputerDecorator ssdDecorator;
            if (rdo128.Checked)
            {
                ssdDecorator = new SSD128Options(ramDecorator);
            }
            else if(rdo256.Checked)
            {
                ssdDecorator = new SSD256Options(ramDecorator);
            }
            else
            {
                ssdDecorator = new SSD512Options(ramDecorator);
            }

            ComputerDecorator decorator;
            if (ckbDiscount.Checked)
            {
                decorator = new DiscountDecorator(ssdDecorator);
            }
            else
            {
                decorator = ssdDecorator;
            }

            lblModel.Text = decorator.Model + " = " + decorator.GetOptionCode();
            lblTotal.Text = decorator.GetPrice().ToString("C");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

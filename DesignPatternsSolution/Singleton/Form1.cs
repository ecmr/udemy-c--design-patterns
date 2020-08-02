﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDoSomenthingBad_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("Form 1 did somthing bad");
            }
            catch (Exception ex)
            {
                ExceptionHandler.Instance.WriteExceptionLog(ex);
            }
        }

        private void btnGoToForm2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}

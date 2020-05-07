﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.Owner = this;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Owner = this;
            this.Visible = false;
        }
    }
}

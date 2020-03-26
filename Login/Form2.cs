﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            textBox1.Text = form1.textBox1.Text;
            textBox2.Text = form1.textBox2.Text;
            this.Text = form1.textBox1.Text;
            form1.Visible = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User user = new User(textBox1.Text, textBox2.Text);
            user.ChangePass("../../Users.txt", textBox1.Text, textBox2.Text);
            
            form1.Visible = true;
            this.Close();
            MessageBox.Show("Сделано!");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            form1.Visible = true;
            this.Close();
        }
    }
}

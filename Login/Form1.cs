using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(textBox1.Text, textBox2.Text);


            if (user.LoginPassIsTrue("../../Users.txt") != "")
            {
                Form2 form2 = new Form2(this);
                form2.Show();
            }
            else
                MessageBox.Show("Не верный логин или пароль");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

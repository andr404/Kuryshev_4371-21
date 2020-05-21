using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR2
{
    public partial class Form2 : Form
    {
        Form1 form1;
        SenderInfoClass senderInfoClass;
        Image image;
        public Form2(Form1 form1, Image image, SenderInfoClass senderInfoClass)
        {
            InitializeComponent();
            this.form1 = form1;
            this.senderInfoClass = senderInfoClass;
            pictureBox1.Image = image;
            label1.Text = senderInfoClass.ToName;
            label2.Text = senderInfoClass.CongrText;
            this.image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Visible = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(senderInfoClass, image);
            form3.Show();
            this.Visible = false;
        }
    }
}

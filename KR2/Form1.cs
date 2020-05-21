using Conference;
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
    public partial class Form1 : Form
    {
        Image _image;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                    _image = Properties.Resources._1;
                if (radioButton2.Checked)
                    _image = Properties.Resources._2;
                if (radioButton3.Checked)
                    _image = Properties.Resources._3;

                string fromName = textBox1.Text;
                string fromEmail = textBox2.Text;
                string toName = textBox3.Text;
                string toEmail = textBox4.Text;
                string congrText = richTextBox1.Text;

                if(toName != "")
                {
                    if(WorkWithInput.IsEmailRight(toEmail) && (fromEmail == "" || WorkWithInput.IsEmailRight(fromEmail)))
                    {
                        SenderInfoClass senderInfoClass = new SenderInfoClass(fromName, fromEmail, toName, toEmail, congrText);
                        Form2 form = new Form2(this, _image, senderInfoClass);
                        form.Show();
                        form.Owner = this;
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Поле 'Кому' должно быть заполнено");
                }
            }
            catch
            {
                MessageBox.Show("Неизвесная ошибка");
            }
        }
    }
}

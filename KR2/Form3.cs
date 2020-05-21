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
    public partial class Form3 : Form
    {
        static СongratulationEntities db = new СongratulationEntities();
        public Form3(SenderInfoClass senderInfoClass, Image image)
        {
            InitializeComponent();
            label3.Text = "Поздравление отправлено на Email " + senderInfoClass.ToEmail;
            pictureBox1.Image = image;
            label1.Text = senderInfoClass.ToName;
            label2.Text = senderInfoClass.CongrText;
            try
            {

                cong cong = new cong
                {
                    email = senderInfoClass.ToEmail,
                    name = senderInfoClass.ToName,
                    congratulation = senderInfoClass.CongrText
                };

                if (senderInfoClass.CongrText == "")
                    cong.congratulation = null;

                db.cong.Add(cong);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка отправки");
            }

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Visible = false;
        }
    }
}

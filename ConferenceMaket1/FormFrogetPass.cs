using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference
{
    public partial class FormFrogetPass : Form
    {
        FormEnter formEnter;
        int code;
        bool IsSended = false;
        string totalEmail = "";
        public FormFrogetPass(FormEnter formEnter)
        {
            InitializeComponent();
            this.formEnter = formEnter;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFrogetPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            formEnter.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (IsSended == false)
            {
                string email = textBox1.Text;
                if (WorkWithInput.IsAllNotEmpty(email))
                {
                    if (BD.HasEmailInBD(email))
                    {
                        totalEmail = email;
                        code = new Random().Next(100000, 999999);
                        SendMailToUser.ForgetPass(email, code);
                        label1.Text = "Введите шестизначный код, который был отправлен\n на вашу почту";
                        IsSended = true;
                        textBox1.Text = "";
                    }
                    else
                        MessageBox.Show("Пользователь с такой почтой не зарегистрирован");
                }
            }
            else
            {
                string inputCode = textBox1.Text;
                if(WorkWithInput.IsAllNotEmpty(inputCode))
                {
                    int prs = 0;
                    int.TryParse(inputCode, out prs);
                    if (prs == code)
                    {
                        formEnter.openEditPass(totalEmail);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный код");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!IsSended)
            {
                string futureEmail = textBox1.Text;
                if (WorkWithInput.IsEmailRight(futureEmail))
                    panel1.BackColor = Color.White;
                else
                    panel1.BackColor = Color.Red;
            }
            else
                panel1.BackColor = Color.White;
        }
    }
}

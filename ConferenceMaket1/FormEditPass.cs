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
    public partial class FormEditPass : Form
    {
        User user;
        Form form;
        bool editWithowPass = false;
        public FormEditPass(Form form, User user)
        {
            InitializeComponent();
            this.user = user;
            this.form = form;
        }
        public FormEditPass(Form form, string email)
        {
            InitializeComponent();
            this.form = form;
            user = BD.GetUserWithoutPass(email);
            editWithowPass = true;
            textBoxOldPass.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldPass = textBoxOldPass.Text;
            string newPass = textBoxNewPass.Text;
            string againPass = textBoxAgainPass.Text;
            if ((WorkWithInput.IsPasswordRight(newPass) && WorkWithInput.IsPasswordRight(againPass) && (editWithowPass || WorkWithInput.IsPasswordRight(oldPass))))
            {
                if (editWithowPass || BD.CheckPass(user.id, oldPass))
                {
                    if (WorkWithInput.IsPasswordsEqual(newPass, againPass))
                    {
                        user.EditPass(newPass);
                        this.Close();
                        MessageBox.Show("Пароль успешно изменен!");
                    }
                }
                else
                    MessageBox.Show("Старый пароль введен не верно");
            }
            else
                MessageBox.Show("Данные введены неверно");
        }

        private void FormEditPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
        }

        private void textBoxOldPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxNewPass_TextChanged(object sender, EventArgs e)
        {
            string futureEmail = textBoxNewPass.Text;
            if (WorkWithInput.IsPasswordRight(futureEmail))
            {
                panel2.BackColor = Color.DarkGray;
                labelAttention.Visible = false;
            }
            else
            {
                panel2.BackColor = Color.Red;
                labelAttention.Visible = true;
            }

            string newPass = textBoxNewPass.Text;
            string againPass = textBoxAgainPass.Text;
            if (newPass == againPass)
            {
                panel3.BackColor = Color.DarkGray;
            }
            else
            {
                panel3.BackColor = Color.Red;
            }
        }

        private void textBoxAgainPass_TextChanged(object sender, EventArgs e)
        {
            string newPass = textBoxNewPass.Text;
            string againPass = textBoxAgainPass.Text;
            if (newPass == againPass)
                panel3.BackColor = Color.DarkGray;
            else
            {
                panel3.BackColor = Color.Red;
            }
        }
    }
}

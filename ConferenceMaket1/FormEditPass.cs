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
        public FormEditPass(Form form, User user)
        {
            InitializeComponent();
            this.user = user;
            this.form = form;
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
            if(WorkWithInput.IsAllNotEmpty(oldPass, newPass, againPass))
            {
                if (BD.CheckPass(user.id, oldPass))
                {
                    if(WorkWithInput.IsPasswordsEqual(newPass, againPass))
                    {
                        user.EditPass(newPass);
                        this.Close();
                        MessageBox.Show("Пароль успешно изменен!");
                    }
                }
                else
                    MessageBox.Show("Старый пароль введен не верно");
            }
        }

        private void FormEditPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
        }
    }
}

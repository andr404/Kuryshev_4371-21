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
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
            textBox_login.Text = Properties.Settings.Default.RememberLogin;
            textBox_pass.Text = Properties.Settings.Default.RememberPass;
            checkRemember.Checked = Properties.Settings.Default.IsRemember;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_pass.Text;
            int statusUser = BD.GetStatus(login, password);
            if (statusUser == 0)
            {
                User user = BD.GetUser(login, password);
                new FormAdminStart(user, this).Show();
                this.Visible = false;
            }
            else if(statusUser > 0)
            {
                User user = BD.GetUser(login, password);
                new FormUserStart(user, this).Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }



            if(checkRemember.Checked)
            {
                SaveLoginAndPass(login, password, true);
            }
            else
            {
                SaveLoginAndPass("", "", false);
            }
            
        }

        private void SaveLoginAndPass(string login, string pass, bool isCheck)
        {
            Properties.Settings.Default.RememberLogin = login;
            Properties.Settings.Default.RememberPass = pass;
            Properties.Settings.Default.IsRemember = isCheck;
            Properties.Settings.Default.Save();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            FormRegistration form = new FormRegistration(this);
            form.Show();
            form.Owner = this;
            this.Enabled = false;
        }

        private void linkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormFrogetPass formFrogetPass = new FormFrogetPass(this);
            formFrogetPass.Show();
            formFrogetPass.Owner = this;
            this.Enabled = false;
        }

        public void openEditPass(string email)
        {
            FormEditPass formEditPass = new FormEditPass(this, email);
            formEditPass.Show();
            formEditPass.Owner = this;
            this.Enabled = true;
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            WorkWithInput.EditPhoneToRight(textBox_login);
        }
    }
}

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
            if (BD.GetStatus(login, password) == 0)
            {
                Admin admin = BD.GetAdmin(login, password);
                new FormAdminStart(admin).Show();
                this.Visible = false;
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

    }
}

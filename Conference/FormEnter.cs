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

        }

    }
}

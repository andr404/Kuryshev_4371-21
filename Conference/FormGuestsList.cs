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
    public partial class FormGuestsList : Form
    {
        FormAdminStart formAdminStart;
        public FormGuestsList(int confId, FormAdminStart formAdminStart)
        {
            InitializeComponent();
            this.formAdminStart = formAdminStart;
            dataGridView1.DataSource = BD.GetGuestsRegistrationList(confId);
        }

        private void FormGuestsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAdminStart.Enabled = true;
        }
    }
}

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
    public partial class FormSpeakersList : Form
    {
        FormAdminStart formAdminStart;
        public FormSpeakersList(int confId, FormAdminStart formAdminStart)
        {
            InitializeComponent();
            this.formAdminStart = formAdminStart;
            dataGridView1.DataSource = BD.GetSpeakersRegistrationList(confId);
        }

        private void FormSpeakersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAdminStart.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Conference
{
    public partial class FormAdminChoiceList : Form
    {
        int id;
        FormAdminStart formAdminStart;
        public FormAdminChoiceList(int confId, FormAdminStart formAdminStart)
        {
            InitializeComponent();
            id = confId;
            this.formAdminStart = formAdminStart;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuests_Click(object sender, EventArgs e)
        {
            formAdminStart.OpenGuestsList(id);
            this.Close();
        }

        private void FormAdminChoiceList_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAdminStart.Enabled = true;
        }

        private void buttonSpeakers_Click(object sender, EventArgs e)
        {
            formAdminStart.OpenSpeakersList(id);
            this.Close();
        }
    }
}

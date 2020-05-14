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
    public partial class FormConferencePresentation : Form
    {
        FormUserStart formUserStart;
        User user;
        int confId;
        public FormConferencePresentation(FormUserStart formUserStart, User user, int confId)
        {
            InitializeComponent();
            this.formUserStart = formUserStart;
            this.user = user;
            this.confId = confId;
            dataGridView1.DataSource = BD.GetSpeakersRegistrationList(confId);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[8].HeaderText = "О себе";

            if (user.status == 1)
            {
                radioButtonSpeaker.Visible = true;
                radioButtonGuest.Visible = true;
            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string topic = textBoxTopic.Text;
            if ((radioButtonSpeaker.Checked && WorkWithInput.IsAllNotEmpty(topic)) || radioButtonGuest.Checked)
            {
                User.RegistrationToConference(user.id, confId, topic);
                this.Close();
            }
                
        }

        private void FormConferencePresentation_FormClosed(object sender, FormClosedEventArgs e)
        {
            formUserStart.Enabled = true;
            formUserStart.UpdateTables();
        }

        private void radioButtonGuest_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGuest.Checked)
            {
                textBoxTopic.Visible = false;
                label3.Visible = false;
            }
            else
            {
                textBoxTopic.Visible = true;
                label3.Visible = true;
            }
        }
    }
}

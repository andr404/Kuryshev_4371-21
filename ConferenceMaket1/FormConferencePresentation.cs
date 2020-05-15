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
        conf conference;
        int emptyPlaceForGuests;
        int emptyPlaceForSpeakers;
        public FormConferencePresentation(FormUserStart formUserStart, User user, int confId)
        {
            InitializeComponent();
            this.formUserStart = formUserStart;
            this.user = user;
            conference = BD.GetConferenceById(confId);
            emptyPlaceForGuests = conference.count_guests - BD.GetGuestsInConference(conference.conf_id).Count;
            emptyPlaceForSpeakers = conference.count_speakers - BD.GetSpeakersInConference(conference.conf_id).Count;

            dataGridView1.DataSource = BD.GetSpeakersRegistrationList(confId);

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Тема выступления";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[7].HeaderText = "О себе";
            dataGridView1.Columns[0].HeaderText = "Тема выступления";

            dataGridView1.Columns[0].DisplayIndex = 7;

            
            labelPlace.Text = string.Format("Свободных мест {0} из {1}", emptyPlaceForGuests, conference.count_guests);
            if(emptyPlaceForGuests <= 0)
            {
                buttonReg.Enabled = false;
            }

            if (user.status == 1)
            {
                label2.Visible = true;
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
                User.RegistrationToConference(user.id, conference.conf_id, topic);
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
                labelPlace.Text = string.Format("Свободных мест {0} из {1}", emptyPlaceForGuests, conference.count_guests);
                if (emptyPlaceForGuests <= 0)
                {
                    buttonReg.Enabled = false;
                }
            }
            else
            {
                textBoxTopic.Visible = true;
                label3.Visible = true;
                labelPlace.Text = string.Format("Свободных мест {0} из {1}", emptyPlaceForSpeakers, conference.count_speakers);
                if (emptyPlaceForSpeakers <= 0)
                {
                    buttonReg.Enabled = false;
                }
            }
        }
    }
}

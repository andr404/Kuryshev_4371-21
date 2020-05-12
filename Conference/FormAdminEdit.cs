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
    public partial class FormAdminEdit : Form
    {
        FormAdminStart form;
        conf conference;
        public FormAdminEdit(FormAdminStart adminStartForm, conf conference)
        {
            InitializeComponent();
            form = adminStartForm;
            this.conference = conference;

            confName.Text = conference.name;
            confSubject.Text = conference.subject;
            confDate.Text = conference.data.ToShortDateString();
            confPlace.Text = conference.place;
            countSpeakers.Value = conference.count_speakers;
            countGuests.Value = conference.count_guests;
            confTime.Text = conference.starttime.ToString();
            

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = confName.Text;
                string subject = confSubject.Text;
                DateTime date = DateTime.Parse(confDate.Text);
                string place = confPlace.Text;
                int speakers = (int)countSpeakers.Value;
                int guests = (int)countGuests.Value;
                TimeSpan time = TimeSpan.Parse(confTime.Text);
                if (name != "" && subject != "" && place != "" && date > DateTime.Now)
                {
                    Admin.EditConference(conference.conf_id, name, subject, date, place, speakers, guests, time);
                    this.Close();
                    MessageBox.Show("Данные успешно сохранены");
                }
                else
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Неправильные данные");
            }
        }

        private void FormAdminEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
            form.UpdateConferences();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormAdminAddConf : Form
    {
        FormAdminStart form;
        public FormAdminAddConf(FormAdminStart formAdmin)
        {
            InitializeComponent();
            form = formAdmin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    Admin.AddConference(name, subject, date, place, speakers, guests, time);
                    this.Close();
                    MessageBox.Show("Новая конференция добавлена");
                }
                else
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Неправильные данные");
            }
        }

        private void FormAdminAddConf_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
            form.UpdateConferences();
        }
    }
}

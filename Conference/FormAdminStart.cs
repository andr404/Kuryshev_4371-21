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
    public partial class FormAdminStart : Form
    {
        User admin;
        FormEnter formEnter;
        public FormAdminStart(User admin, FormEnter formEnter)
        {
            InitializeComponent();
            this.admin = admin;
            this.formEnter = formEnter;
            UpdateConferences();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminAddConf form = new FormAdminAddConf(this);
            form.Show();
            form.Owner = this;
            this.Enabled = false;
        }

        public void UpdateConferences()
        {
            var confs = BD.GetAllConferences();
            dataGridView1.DataSource = confs;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1 || dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    conf conference = new conf
                    {
                        conf_id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value,
                        name = dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value.ToString(),
                        subject = dataGridView1.SelectedCells[0].OwningRow.Cells[2].Value.ToString(),
                        data = (DateTime)dataGridView1.SelectedCells[0].OwningRow.Cells[3].Value,
                        place = dataGridView1.SelectedCells[0].OwningRow.Cells[4].Value.ToString(),
                        count_speakers = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[5].Value,
                        count_guests = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[6].Value,
                        starttime = (TimeSpan)dataGridView1.SelectedCells[0].OwningRow.Cells[7].Value
                    };

                    FormAdminEdit form = new FormAdminEdit(this, conference);
                    form.Show();
                    form.Owner = this;
                    this.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Ошибка выбора конференции");
                }
            }
            else
                MessageBox.Show("Вырите одну конференцию");
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1 || dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    int conf_id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value;
                    FormAdminChoiceList form = new FormAdminChoiceList(conf_id, this);
                    form.Show();
                    form.Owner = this;
                    this.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Ошибка открытия диалогового окна");
                }
            }
            else
                MessageBox.Show("Вырите одну конференцию");
        }

        public void OpenGuestsList(int confId)
        {
            FormGuestsList form = new FormGuestsList(confId, this);
            form.Show();
            form.Owner = this;
            this.Enabled = false;
        }

        public void OpenSpeakersList(int confId)
        {
            FormSpeakersList form = new FormSpeakersList(confId, this);
            form.Show();
            form.Owner = this;
            this.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormEditProfile form = new FormEditProfile(admin, this);
            form.Show();
            form.Owner = this;
            this.Enabled = false;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Properties.Settings.Default.RememberLogin = "";
            Properties.Settings.Default.RememberPass = "";
            Properties.Settings.Default.IsRemember = false;
            Properties.Settings.Default.Save();
            this.Close();
            formEnter.Visible = true;
            formEnter.textBox_login.Text = "";
            formEnter.textBox_pass.Text = "";
            formEnter.checkRemember.Checked = false;
        }
    }
}

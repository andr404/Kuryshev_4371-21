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
    public partial class FormUserStart : Form
    {
        User user;
        FormEnter formEnter;
        public FormUserStart(User user, FormEnter formEnter)
        {
            InitializeComponent();
            this.user = user;
            this.formEnter = formEnter;
            UpdateTables();
            UpdateName();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Тематика";
            dataGridView1.Columns[3].HeaderText = "Дата проведения";
            dataGridView1.Columns[4].HeaderText = "Место";
            dataGridView1.Columns[5].HeaderText = "Кол. выступающих";
            dataGridView1.Columns[6].HeaderText = "Кол. зрителей";
            dataGridView1.Columns[7].HeaderText = "Время";

            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Название";
            dataGridView2.Columns[2].HeaderText = "Тематика";
            dataGridView2.Columns[3].HeaderText = "Дата проведения";
            dataGridView2.Columns[4].HeaderText = "Место";
            dataGridView2.Columns[5].HeaderText = "Кол. выступающих";
            dataGridView2.Columns[6].HeaderText = "Кол. зрителей";
            dataGridView2.Columns[7].HeaderText = "Время";

        }

        public void UpdateName()
        {
            label1.Text = user.Surname + " " + user.Name + " " + user.LastName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile(user, this);
            formEditProfile.Show();
            formEditProfile.Owner = this;
            this.Enabled = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Properties.Settings.Default.RememberLogin = "";
            Properties.Settings.Default.RememberPass = "";
            Properties.Settings.Default.IsRemember = false;
            Properties.Settings.Default.Save();
            this.Hide();
            formEnter.Visible = true;
            formEnter.textBox_login.Text = user.Email;
            formEnter.textBox_pass.Text = "";
            formEnter.checkRemember.Checked = false;
        }

        public void UpdateTables()
        {
            var futureList = BD.GetFutureConferences(user.id);
            dataGridView2.DataSource = futureList;
            var myList = BD.GetMyConferences(user.id);
            dataGridView1.DataSource = myList;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedCells.Count == 1 || dataGridView2.SelectedRows.Count == 1)
            {
                int confId = (int) dataGridView2.SelectedCells[0].OwningRow.Cells[0].Value;
                FormConferencePresentation form = new FormConferencePresentation(this, user, confId);
                form.Show();
                form.Owner = this;
                this.Enabled = false;
            }
        }

        private void buttonUnreg_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1 || dataGridView1.SelectedRows.Count == 1)
            {
                int confId = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value;
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    User.RemoveMyRecord(user.id, confId);
                    MessageBox.Show("Запись успешно удалена");
                    UpdateTables();
                }
            }
        }

        private void FormUserStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

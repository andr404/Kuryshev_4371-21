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
            this.Close();
            formEnter.Visible = true;
            formEnter.textBox_login.Text = "";
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
    }
}

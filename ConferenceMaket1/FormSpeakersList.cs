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
            dataGridView1.Columns[1].HeaderText = "Тема выступления";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Телефон";
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "О себе";
            dataGridView1.Columns[0].HeaderText = "Тема выступления";
            dataGridView1.Columns[0].DisplayIndex = 7;
        }

        private void FormSpeakersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAdminStart.Enabled = true;
        }
    }
}

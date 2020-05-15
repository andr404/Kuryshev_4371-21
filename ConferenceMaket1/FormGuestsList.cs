﻿using System;
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
    public partial class FormGuestsList : Form
    {
        FormAdminStart formAdminStart;
        public FormGuestsList(int confId, FormAdminStart formAdminStart)
        {
            InitializeComponent();
            this.formAdminStart = formAdminStart;
            dataGridView1.DataSource = BD.GetGuestsRegistrationList(confId);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Телефон";
            dataGridView1.Columns[5].HeaderText = "Email";
        }

        private void FormGuestsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAdminStart.Enabled = true;
        }
    }
}

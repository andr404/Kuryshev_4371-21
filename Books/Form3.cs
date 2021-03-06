﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.booksDataSet.books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Visible = true;
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Visible = true;
            if (Application.OpenForms.Count == 2)
                this.Close();
        }

    }
}

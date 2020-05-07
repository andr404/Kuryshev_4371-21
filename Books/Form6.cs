using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.booksDataSet.books);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewColumn Col = dataGridView1.Columns[0];
                switch (listBox1.SelectedIndex)
                {
                    case 0: Col = dataGridView1.Columns[0]; break;
                    case 1: Col = dataGridView1.Columns[1]; break;
                }
                if (radioButton1.Checked)
                {
                    dataGridView1.Sort(Col, ListSortDirection.Ascending);
                }
                else
                    dataGridView1.Sort(Col, ListSortDirection.Descending);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "name_book='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                {
                    for (int j = 0; j < (dataGridView1.ColumnCount); j++)
                    {
                        DataGridViewCell cell = dataGridView1.Rows[i].Cells[j];
                        cell.Style.BackColor = Color.White;
                        cell.Style.ForeColor = Color.Black;
                    }
                }
                for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                {
                    for (int j = 0; j < (dataGridView1.ColumnCount); j++)
                    {
                        DataGridViewCell cell = dataGridView1.Rows[i].Cells[j];
                        cell.Style.BackColor = Color.AliceBlue;
                        cell.Style.ForeColor = Color.Blue;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Visible = true;
            this.Close();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Visible = true;
            if (Application.OpenForms.Count == 3)
                this.Close();
        }
    }
}

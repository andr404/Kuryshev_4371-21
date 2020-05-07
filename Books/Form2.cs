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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void authorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.authorsTableAdapter.Fill(this.booksDataSet.authors);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form7().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Visible = true;
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Visible = true;
            if(Application.OpenForms.Count == 2)
            this.Close();
        }
    }
}

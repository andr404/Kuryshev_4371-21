using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR2
{
    public partial class Form4 : Form
    {
        static СongratulationEntities db = new СongratulationEntities();
        public Form4()
        {
            InitializeComponent();
            try
            {
                var mails = (from e in db.cong
                             select e).ToList();
                dataGridView1.DataSource = mails;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[2].HeaderText = "Почта";

            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка");
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

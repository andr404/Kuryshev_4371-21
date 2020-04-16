using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR
{
    public partial class Form2 : Form
    {
        contEntities db = new contEntities();
        public Form2()
        {
            InitializeComponent();

            var query = (from stud in db.s_students
                         join g in db.s_in_group on stud.id_group equals g.id_group
                         select new { stud.id, stud.surname, stud.name, stud.middlename, g.kurs_num, g.group_num }).ToList();

            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].HeaderText = "Номер_зачетной_книжки";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "ИМя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Номер_курса";
            dataGridView1.Columns[5].HeaderText = "Номер группы";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;

            if(t1 == "" && t2 == "" && t3 == "")
            {
                var query = (from stud in db.s_students
                             join g in db.s_in_group on stud.id_group equals g.id_group
                             select new { stud.id, stud.surname, stud.name, stud.middlename, g.kurs_num, g.group_num }).ToList();

                dataGridView1.DataSource = query;
            }

            if (t1 != "")
            {
                


                var s1 = (from s in db.s_students
                          join g in db.s_in_group on s.id_group equals g.id_group
                          where s.surname == t1
                          select new { s.id, s.surname, s.name, s.middlename, g.kurs_num, g.group_num }).ToList();
                dataGridView1.DataSource = s1;
            }
            if (t2 != "")
            {
                int temp;
                if (int.TryParse(t2, out temp))
                {
                    var s1 = (from s in db.s_students
                              join g in db.s_in_group on s.id_group equals g.id_group
                              where g.kurs_num == temp
                              select new { s.id, s.surname, s.name, s.middlename, g.kurs_num, g.group_num }).ToList();
                    dataGridView1.DataSource = s1;
                }
                else
                    MessageBox.Show("Номер курса - это цифра");
            }

            if (t3 != "")
            {
                int temp;
                if (int.TryParse(t3, out temp))
                {
                    var s1 = (from s in db.s_students
                              join g in db.s_in_group on s.id_group equals g.id_group
                              where g.group_num == temp
                              select new { s.id, s.surname, s.name, s.middlename, g.kurs_num, g.group_num }).ToList();
                    dataGridView1.DataSource = s1;
                }
                else
                    MessageBox.Show("Номер курса - это цифра");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                textBox3.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = (from stud in db.s_students
                         join g in db.s_in_group on stud.id_group equals g.id_group
                         select new { stud.id, stud.surname, stud.name, stud.middlename, g.kurs_num, g.group_num }).ToList();

            dataGridView1.DataSource = query;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddGroup form = new AddGroup();
            form.Show();
            form.Owner = this;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                int temp = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value;
                s_students stud = (from s in db.s_students
                                   where s.id == temp
                                   select s).FirstOrDefault();

                Change_group form = new Change_group(stud);
                form.Show();
                form.Owner = this;


            }
        }
    }
}

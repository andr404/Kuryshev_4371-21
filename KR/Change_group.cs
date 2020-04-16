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
    public partial class Change_group : Form
    {
        contEntities db = new contEntities();
        public Change_group(s_students stud)
        {
            InitializeComponent();

            textBox1.Text = stud.surname;
            textBox2.Text = stud.name;
            textBox3.Text = stud.middlename;

            int group = (from s in db.s_students
                         join g in db.s_in_group on s.id_group equals g.id_group
                         where s.id == stud.id
                         select g.group_num).FirstOrDefault();
            comboBox1.Text = group.ToString();

            int kurs = (from s in db.s_students
                         join g in db.s_in_group on s.id_group equals g.id_group
                         where s.id == stud.id
                         select g.kurs_num).FirstOrDefault();
            comboBox2.Text = kurs.ToString();

            var groups = (from s in db.s_students
                          join g in db.s_in_group on s.id_group equals g.id_group
                          select g.group_num).ToList();

            comboBox1.Items.Clear();
            foreach(var i in groups)
            {
                comboBox1.Items.Add((int)i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

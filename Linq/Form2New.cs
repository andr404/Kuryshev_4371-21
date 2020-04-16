using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form2New : Form
    {
        demoEntities db = new demoEntities();

        public Form2New()
        {
            InitializeComponent();

            var stud_surnames = (from stud in db.students
                                 select new { stud.surname }).ToList();
            var lect_names = (from l in db.lectors
                              select new { l.name_lector }).ToList();
            var sub_names = (from sub in db.subjects
                             select sub.name_subject).ToList();

            foreach (var s in stud_surnames) // Список фамилий в комбобокс
            {
                comboBox1.Items.Add(ToCombo(s.ToString()));
            }
            var stud_names = (from stud in db.students // Список в combobox2
                              where stud.surname == comboBox1.Text
                              select new { stud.name }).ToList();
            foreach (var s in stud_names)
            {
                comboBox2.Items.Add(ToCombo(s.ToString()));
            }
            foreach (var s in lect_names) // Заполнение комбобокс3 (Препод)
            {
                comboBox3.Items.Add(ToCombo(s.ToString()));
            }
            foreach (var s in sub_names) // Заполнение комбобокс3 (Препод)
            {
                comboBox4.Items.Add(s);
            }

        }

        static string ToCombo(string str)
        {
            string temp = str.ToString().Split('=')[1];
            temp = temp.Remove(0, 1);
            temp = temp.Remove(temp.Length - 2, 2);
            return temp;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // combobox2 при изменении combobox1
        {
            var stud_names = (from stud in db.students
                              where stud.surname == comboBox1.Text
                              select new { stud.name }).ToList();
            comboBox2.Items.Clear();
            foreach (var s in stud_names)
            {
                comboBox2.Items.Add(ToCombo(s.ToString()));
            }

            if (!comboBox2.Items.Contains(comboBox2.Text))
            {
                comboBox2.Text = comboBox2.Items[0].ToString(); ;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d;
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && DateTime.TryParse(textBox1.Text, out d))
            {
                progress p = new progress
                {
                    code_lector = (from l in db.lectors
                                   where l.name_lector == comboBox3.Text
                                   select l.code_lector).FirstOrDefault(),
                    code_stud = (from s in db.students
                                 where s.name == comboBox2.Text && s.surname == comboBox1.Text
                                 select s.code_stud).FirstOrDefault(),
                    code_subject = (from sub in db.subjects
                                    where sub.name_subject == comboBox4.Text
                                    select sub.code_subject).FirstOrDefault(),
                    date_exam = d,
                    estimate = int.Parse(textBox2.Text)
                };

                db.progresses.Add(p);

                db.SaveChanges();
                this.Close();
                MessageBox.Show("Изменения сохранены!");
            }
        }
    }
}

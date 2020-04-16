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
    public partial class Form2Pdate : Form
    {
        demoEntities db = new demoEntities();
        progress progr;
        public Form2Pdate(progress prog)
        {
            InitializeComponent();

            progr = prog;
            comboBox1.Text = (from s in db.students
                        where s.code_stud == prog.code_stud
                        select s.surname ).FirstOrDefault();
            comboBox2.Text = (from s in db.students
                              where s.code_stud == prog.code_stud
                              select s.name).FirstOrDefault();
            comboBox3.Text = (from l in db.lectors
                              where l.code_lector == prog.code_lector
                              select l.name_lector).FirstOrDefault();
            comboBox4.Text = (from sub in db.subjects
                              where sub.code_subject == prog.code_subject
                              select sub.name_subject).FirstOrDefault();
            textBox1.Text = prog.date_exam.ToShortDateString();


            var stud_surnames = (from stud in db.students
                                 select new { stud.surname }).ToList();
            var lect_names = (from l in db.lectors
                              select new { l.name_lector }).ToList();
            var sub_names = (from sub in db.subjects
                             select sub.name_subject).ToList();

            foreach(var s in stud_surnames) // Список фамилий в комбобокс
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

            if(!comboBox2.Items.Contains(comboBox2.Text))
            {
                comboBox2.Text = comboBox2.Items[0].ToString(); ;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d;
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && DateTime.TryParse(textBox1.Text, out d))
            {
                var temp = db.progresses.Where(s => s.code_lector == progr.code_lector && s.code_stud == progr.code_stud && s.code_subject == progr.code_subject && s.date_exam == progr.date_exam)
                    .FirstOrDefault();
                temp.code_lector = progr.code_lector;
                temp.code_stud = progr.code_stud;
                temp.code_subject = progr.code_subject;
                temp.date_exam = progr.date_exam;
                temp.estimate = int.Parse(textBox2.Text);
                db.SaveChanges();
                this.Close();
                MessageBox.Show("Изменения сохранены!");
            }
        }
    }
}

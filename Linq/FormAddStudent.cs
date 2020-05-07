﻿using System;
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
    public partial class FormAddStudent : Form
    {
        public demoEntities db = new demoEntities();

        public List<student> studentsheet;
        public FormAddStudent()
        {
            try
            {
                InitializeComponent();

                var groups_for_list = (from g in db.groups
                                       select g.name_group).Distinct();

                foreach (string it in groups_for_list)
                {
                    comboBox1.Items.Add(it);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var query = (from g in db.groups
                             where g.name_group == comboBox1.SelectedItem.ToString()
                             select g.code_group).ToList();
                int number_of_students = db.students.Max(n => n.code_stud) + 1;

                student new_student = new student
                {
                    code_stud = number_of_students,
                    surname = textBox1.Text,
                    name = textBox2.Text,
                    code_group = query[0]
                };
                db.students.Add(new_student);

                db.SaveChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

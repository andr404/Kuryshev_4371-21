using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.XSSF.UserModel;
using System.IO;

namespace Linq
{
    public partial class Form2 : Form
    {
        demoEntities db = new demoEntities();

        public Form2()
        {
            try
            {
                InitializeComponent();

                var uspev = (from stud in db.students
                             join p in db.progresses on stud.code_stud equals p.code_stud
                             join sub in db.subjects on p.code_subject equals sub.code_subject
                             join l in db.lectors on p.code_lector equals l.code_lector
                             orderby stud.code_stud
                             select new { sub.name_subject, l.name_lector, stud.name, stud.surname, p.estimate, p.code_stud, p.code_lector, p.code_subject, p.date_exam }).ToList();
                dataGridView1.DataSource = uspev;

                dataGridView1.Columns[0].HeaderText = "Наименование предмета";
                dataGridView1.Columns[1].HeaderText = "Преподаватель";
                dataGridView1.Columns[2].HeaderText = "Имя";
                dataGridView1.Columns[3].HeaderText = "Фамилия";
                dataGridView1.Columns[4].HeaderText = "Оценка";
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
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
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFile.DefaultExt = ".xls";
                saveFile.Filter =
                    "Таблицы Excel (*.xls)|*.xls|Все файлы (*.*)|*.*";
                saveFile.FilterIndex = 1;
                saveFile.FileName = "Могло быть и лучше";

                var uspev = (from stud in db.students
                             join p in db.progresses on stud.code_stud equals p.code_stud
                             join sub in db.subjects on p.code_subject equals sub.code_subject
                             orderby stud.code_stud
                             select new { sub.name_subject, stud.name, stud.surname, p.estimate }).ToList();

                var template = new MemoryStream(Properties.Resources.usp, true);

                var workbook = new XSSFWorkbook(template);
                var sheet1 = workbook.GetSheet("Лист1");

                int row = 19;
                foreach (var item in uspev)
                {
                    var rowInsert = sheet1.CreateRow(row);
                    rowInsert.CreateCell(12).SetCellValue(item.name_subject);
                    rowInsert.CreateCell(13).SetCellValue(item.name);
                    rowInsert.CreateCell(14).SetCellValue(item.surname);
                    rowInsert.CreateCell(15).SetCellValue(item.estimate.ToString());
                    row++;

                }

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    var file = new FileStream(saveFile.FileName,
                        FileMode.Create,
                        FileAccess.ReadWrite);
                    workbook.Write(file);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string search = textBox1.Text;
                string combo = comboBox1.Text;

                var query = (from stud in db.students
                             join p in db.progresses on stud.code_stud equals p.code_stud
                             join sub in db.subjects on p.code_subject equals sub.code_subject
                             join l in db.lectors on p.code_lector equals l.code_lector
                             orderby stud.code_stud
                             select new { sub.name_subject, l.name_lector, stud.name, stud.surname, p.estimate }).ToList();

                if (textBox1.Text != "")
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            dataGridView1.DataSource = query.Where(p => p.name_subject.ToString() == textBox1.Text.ToString()).ToList(); break;
                        case 1:
                            dataGridView1.DataSource = query.Where(l => l.name_lector.ToString() == textBox1.Text.ToString()).ToList(); break;
                        case 2:
                            dataGridView1.DataSource = query.Where(p => p.surname.ToString() == textBox1.Text.ToString()).ToList(); break;
                        case 3:
                            dataGridView1.DataSource = query.Where(p => p.estimate.ToString() == textBox1.Text.ToString()).ToList(); break;
                    }
                }
                else
                    dataGridView1.DataSource = query;
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    progress p = new progress
                    {
                        code_stud = int.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[5].Value.ToString()),
                        code_lector = int.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[6].Value.ToString()),
                        code_subject = int.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[7].Value.ToString()),
                        date_exam = (DateTime)dataGridView1.SelectedCells[0].OwningRow.Cells[8].Value,
                        estimate = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[4].Value
                    };

                    Form2Pdate form = new Form2Pdate(p);
                    form.Show();
                    form.Owner = this;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2New form = new Form2New();
            form.Show();
            form.Owner = this;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    progress p = new progress
                    {
                        code_stud = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[5].Value,
                        code_lector = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[6].Value,
                        code_subject = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[7].Value,
                        date_exam = (DateTime)dataGridView1.SelectedCells[0].OwningRow.Cells[8].Value,
                        estimate = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[4].Value
                    };

                    var del = (from pr in db.progresses
                               where pr.code_stud == p.code_stud
                               && pr.code_lector == p.code_lector
                               && pr.code_subject == p.code_subject
                               && pr.estimate == p.estimate
                               select pr).FirstOrDefault();

                    db.progresses.Remove(del);
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }
                else
                {
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Visible = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Application.OpenForms.Count == 2)
            this.Close();
            Application.OpenForms[0].Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text != "")
            {
                if (comboBox1.Text == "Оценка")
                {
                    for (int i = 0; i < text.Length; i++)
                        if (!char.IsDigit(text[i]))
                        {
                            text = text.Remove(i, 1);
                        }
                }
                else
                {
                    for (int i = 0; i < text.Length; i++)
                        if (!char.IsLetter(text[i]))
                        {
                            text = text.Remove(i, 1);
                        }
                }
            }
            textBox1.Text = text;
        }
    }
    
}

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
    public partial class AddGroup : Form
    {
        contEntities db = new contEntities();
        public AddGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kurs, group;

            if (int.TryParse(textBox1.Text, out kurs) && int.TryParse(textBox2.Text, out group))
            {
                if (kurs > 0 && kurs < 7)
                {
                    s_in_group new_group = new s_in_group
                    {
                        id_group = db.s_in_group.Max(i => i.id_group) + 1,
                        group_num = group,
                        kurs_num = kurs
                    };
                    db.s_in_group.Add(new_group);
                    db.SaveChanges();
                    this.Close();
                    MessageBox.Show("Сохранено!");
                }
                else
                    MessageBox.Show("Курс может быть от 1 до 6");
            }
            else
                MessageBox.Show("Введите числа");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

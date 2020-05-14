using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference
{
    public partial class FormEditProfile : Form
    {
        Form lastForm;
        User user;
        public FormEditProfile(User user, Form form)
        {
            InitializeComponent();
            lastForm = form;
            this.user = user;

            textBoxSurname.Text = user.Surname;
            textBoxName.Text = user.Name;
            textBoxLastName.Text = user.LastName;
            maskedPhone.Text = user.Phone;
            textBoxEmail.Text = user.Email;
            if(user.status == 1)
            {
                label8.Visible = true;
                textBoxAbout.Visible = true;
                textBoxAbout.Text = user.AboutYourSelf;
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            lastForm.Enabled = true;
            if(lastForm is FormUserStart)
            {
                FormUserStart form = (FormUserStart)lastForm;
                form.UpdateName();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string surname = textBoxSurname.Text;
                string name = textBoxName.Text;
                string lastname = textBoxLastName.Text;
                string phone = WorkWithInput.PhoneWhithoutMask(maskedPhone.Text);
                string email = textBoxEmail.Text;
                string about = textBoxAbout.Text;
                if (WorkWithInput.IsAllNotEmpty(surname, name, phone, email) && ((user.status == 1 && about != "") || user.status != 1))
                {
                    user.EditProfile(surname, name, lastname, phone, email, about);
                    this.Close();
                    MessageBox.Show("Данные успешно изменены");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка, данные не изменены");
            }
        }

        

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            WorkWithInput.GetClearTextBox(textBoxSurname);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            WorkWithInput.GetClearTextBox(textBoxName);
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            WorkWithInput.GetClearTextBox(textBoxLastName);
        }

        private void buttonEditPass_Click(object sender, EventArgs e)
        {
            FormEditPass formEditPass = new FormEditPass(this, user);
            formEditPass.Show();
            formEditPass.Owner = this;
            this.Enabled = false;
        }
    }
}

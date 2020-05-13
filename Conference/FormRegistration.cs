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
    public partial class FormRegistration : Form
    {
        FormEnter formEnter;
        public FormRegistration(FormEnter formEnter)
        {
            InitializeComponent();
            this.formEnter = formEnter;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            try
            {
                string surname = textBoxSurname.Text;
                string name = textBoxName.Text;
                string lastname = textBoxLastName.Text;
                string phone = WorkWithInput.PhoneWhithoutMask(maskedPhone.Text);
                string email = textBoxEmail.Text;
                string pass = textBoxPass.Text;
                string pass2 = textBoxPassAgain.Text;
                int status = radioButtonGuest.Checked ? 2 : 1;
                string aboutYourSelf = textBoxAbout.Text;
                if (WorkWithInput.IsAllNotEmpty(surname, name, phone, email, pass, pass2) && ((status == 1 && aboutYourSelf != "") || status != 1) && WorkWithInput.IsPasswordsEqual(pass, pass2))
                {
                    if (!WorkWithInput.IsEmailInBase(email) && !WorkWithInput.IsPhoneInBase(phone))
                    {
                        User.CreateNewUser(surname, name, lastname, phone, email, pass, status, aboutYourSelf);
                        this.Close();
                        MessageBox.Show("Данные успешно изменены");
                    }
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            formEnter.Enabled = true;
        }

        private void radioButtonSpeaker_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonSpeaker.Checked)
            {
                label8.Visible = true;
                textBoxAbout.Visible = true;
            }
            else
            {
                label8.Visible = false;
                textBoxAbout.Visible = false;
            }
        }
    }
}

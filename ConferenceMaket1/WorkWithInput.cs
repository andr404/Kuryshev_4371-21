using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference
{
    public static class WorkWithInput
    {
        public static void GetClearTextBox(TextBox textBox)
        {
            string text = textBox.Text;
            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsLetter(text[i]))
                {
                    text = text.Remove(i, 1);
                    i--;
                }
            }
            if (text.Length > 0)
            {
                char temp = Char.ToUpper(text[0]);
                text = text.Remove(0, 1);
                text = text.Insert(0, temp.ToString());
            }
            textBox.Text = text;
            textBox.SelectionStart = text.Length;
        }

        public static string PhoneWhithoutMask(string phone)
        {
            for (int i = 1; i < phone.Length; i++)
            {
                if (!Char.IsDigit(phone[i]))
                {
                    phone = phone.Remove(i, 1);
                    i--;
                }
            }
            return phone;
        }

        public static bool IsPasswordsEqual(string pass1, string pass2)
        {
            if (pass1 == pass2)
                return true;
            else
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }
        }

        public static bool IsAllNotEmpty(params string[] mas)
        {
            foreach(string str in mas)
            {
                if(str == "")
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                    return false;
                }
            }
            return true;
        }

        public static bool IsEmailInBase(string email)
        {
            if(!BD.HasEmailInBD(email))
            {
                return false;
            }
            else
            {
                MessageBox.Show("Пользователь с данной почтой уже зарегистрирован");
                return true;
            }
        }

        public static bool IsPhoneInBase(string phone)
        {
            if (!BD.HasPhoneInBD(phone))
            {
                return false;
            }
            else
            {
                MessageBox.Show("Пользователь с таким номером телефона уже зарегистрирован");
                return true;
            }
        }

        public static bool IsEmailRight(string email)
        {
            if (email.Contains('@') && email.Contains('.'))
                return true;
            else
            {
                return false;
            }
        }
        public static bool IsPasswordRight(string pass)
        {
            bool upChar = false;
            bool downChar = false;
            bool number = false;
            foreach(char c in pass)
            {
                if (char.IsUpper(c))
                    upChar = true;
                if (char.IsLower(c))
                    downChar = true;
                if (char.IsDigit(c))
                    number = true;
            }
            if (upChar && downChar && number && pass.Length > 7)
                return true;
            else return false;
        }
        public static bool IsPhoneRight(string phone)
        {
            phone = PhoneWhithoutMask(phone);
            if (phone.Length == 12)
                return true;
            else 
            {
                MessageBox.Show("Номер телефона введен неверно");
                return false; 
            }
        }

        public static void EditPhoneToRight(TextBox textBox)
        {
            string text = textBox.Text;
            if(text.Length == 11)
            {
                bool allNums = true;
                foreach(char c in text)
                {
                    if (!char.IsDigit(c))
                        allNums = false;
                }
                if(allNums)
                {
                    text = text.Remove(0, 1);
                    text = text.Insert(0, "+7");
                    textBox.Text = text;
                }
            }
        }


    }
}

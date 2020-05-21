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

        public static bool IsEmailRight(string email)
        {
            if (email.Contains('@') && email.Contains('.'))
                return true;
            else
            {
                MessageBox.Show("Email указан неверно");
                return false;
            }
        }


    }
}

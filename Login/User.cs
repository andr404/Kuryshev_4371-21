using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login
{
    class User
    {
        string login, password;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string LoginPassIsTrue(string file_name)
        {
            string[] big_mas = File.ReadAllLines(file_name);
            
            for(int i = 0 ; i < big_mas.Length; i++)
            {
                string[] mas = big_mas[i].Split('*');

                if(mas[0] == login && mas[1] == password)
                {
                    return mas[2];
                }
            }

            return "";
        }

        public void ChangePass(string file_name, string login1, string newPass)
        {
            StreamReader sr = new StreamReader(file_name);
            string to_end = sr.ReadToEnd();
            string[] mas = to_end.Split('\n', '\r');


            sr.Close();
            StreamWriter sw = new StreamWriter(file_name);
                        

            foreach(string str in mas)
            {
                string[] m = str.Split('*');


                if(str != "")
                {
                    string[] s = str.Split('*');
                    if(s[0] == login1)
                    {
                        sw.WriteLine(m[0] + "*" + newPass + "*" + m[2]);
                    }
                    else
                    {
                        sw.WriteLine(str);
                    }
                }

            }
            sw.Close();



        }

    }
}

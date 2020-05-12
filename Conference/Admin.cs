using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{
    public class Admin
    {
        public readonly int id;
        string phone, email, pass;

        public Admin(int id, string phone, string email, string pass)
        {
            this.id = id;
            this.phone = phone;
            this.email = email;
            this.pass = pass;
        }

        public static void AddConference(string name, string subject, DateTime dateTime, string place, int countSpeakers, int countGuests, TimeSpan time)
        {
            BD.AddConference(name, subject, dateTime, place, countSpeakers, countGuests, time);
        }

        public static void EditConference(int id, string newName, string newSubject, DateTime newDateTime, string newPlace, int newCountSpeakers, int newCountGuests, TimeSpan newTime)
        {
            BD.EditConference(id, newName, newSubject, newDateTime, newPlace, newCountSpeakers, newCountGuests, newTime);

            // Отправка мэйлов
        }

    }
}

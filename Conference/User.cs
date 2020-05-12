using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{
    class User
    {
        public readonly int id, status;
        string surname, name, lastname, phone, email, pass;

        public User(int id, string surname, string name, string lastname, string phone, string email, string pass, int status)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.email = email;
            this.pass = pass;
            this.status = status;
        }

        public static void AdminAddConference(string name, string subject, DateTime dateTime, string place, int countSpeakers, int countGuests, TimeSpan time)
        {
            BD.AddConference(name, subject, dateTime, place, countSpeakers, countGuests, time);
        }

        public static void AdminEditConference(int id, string newName, string newSubject, DateTime newDateTime, string newPlace, int newCountSpeakers, int newCountGuests, TimeSpan newTime)
        {
            BD.EditConference(id, newName, newSubject, newDateTime, newPlace, newCountSpeakers, newCountGuests, newTime);

            // Отправка мэйлов
        }

    }
}

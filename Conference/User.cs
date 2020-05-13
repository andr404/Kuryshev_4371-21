using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{
    public class User
    {
        public readonly int id, status;
        private string surname, name, lastname, phone, email, pass, aboutYourSelf;

        public User(int id, string surname, string name, string lastname, string phone, string email, string pass, int status, string aboutYourSelf)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.email = email;
            this.pass = pass;
            this.status = status;
            this.aboutYourSelf = aboutYourSelf;
        }

        public string Surname
        {
            get => surname;
        }
        public string Name
        {
            get => name;
        }
        public string LastName
        {
            get => lastname;
        }
        public string Phone
        {
            get => phone;
        }
        public string Email
        {
            get => email;
        }
        public string Password
        {
            get => pass;
        }
        public string AboutYourSelf
        {
            get => aboutYourSelf;
        }


        public void EditProfile(string newSurname, string newName, string newLastName, string newPhone, string newMail, string newPass, string aboutYourSelf = null)
        {
            CheckNullParams(ref newLastName, ref aboutYourSelf);
            BD.EditUser(id, newSurname, newName, newLastName, newPhone, newMail, newPass, aboutYourSelf);
            surname = newSurname;
            name = newName;
            lastname = newLastName;
            this.aboutYourSelf = aboutYourSelf;
            if (phone != newPhone || email != newMail || pass != newPass)
            {
                // Отавить письмо на почту//////////////////////////////////////////////////////////////////////////////////////////////////////////
                phone = newPhone;
                email = newMail;
                pass = newPass;
                Properties.Settings.Default.RememberLogin = "";
                Properties.Settings.Default.RememberPass = "";
                Properties.Settings.Default.Save();
            }
        }


        public static void AdminAddConference(string name, string subject, DateTime dateTime, string place, int countSpeakers, int countGuests, TimeSpan time)
        {
            BD.AddConference(name, subject, dateTime, place, countSpeakers, countGuests, time);
        }

        public static void AdminEditConference(int id, string newName, string newSubject, DateTime newDateTime, string newPlace, int newCountSpeakers, int newCountGuests, TimeSpan newTime)
        {
            BD.EditConference(id, newName, newSubject, newDateTime, newPlace, newCountSpeakers, newCountGuests, newTime);

            // Отправка мэйлов/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        public static void AdminDeleteConference(int confId)
        {
            BD.DeleteConference(confId);
            // Отправка мэйлов/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        public static void RegistrationToConference(int userId, int confId, string topic)
        {
            if (topic == "") topic = null;
            BD.RegisterToConference(userId, confId, topic);
        }

        public static void RemoveMyRecord(int userId, int confId)
        {
            BD.RemoveMyConference(userId, confId);
        }


        public static void CreateNewUser(string surname, string name, string lastName, string phone, string email, string pass, int status, string aboutYourSelf = null)
        {
            CheckNullParams(ref lastName, ref aboutYourSelf);
            BD.AddUser(surname, name, lastName, phone, email, pass, status, aboutYourSelf);
        }

        static void CheckNullParams(ref string lastname, ref string aboutYourSelf)
        {
            if (lastname == "")
                lastname = null;
            if (aboutYourSelf == "")
                aboutYourSelf = null;
        }

    }
}

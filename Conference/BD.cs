using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Entity.Validation;

namespace Conference
{
    static class BD
    {
        static ConferenceEntities1 db = new ConferenceEntities1();


        
        static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }




        public static int GetStatus(string login, string password)
        {
            // Метод возвращвет статус аккаунта или -1, при его отсутствии
            try
            {
                string hashPass = GetHash(password);
                var userList = (from user in db.users
                                where (user.email == login || user.phone == login) && user.pass == hashPass
                                select user).ToList();
                if (userList.Count == 0)
                    return -1;
                else
                    return userList[0].status;
            }
            catch
            {
                MessageBox.Show("Ошибка запроса");
                return -1;
            }
        }

        public static bool HasEmailInBD(string email)
        {
            var userList = (from user in db.users
                            where user.email == email
                            select user).ToList();
            if (userList.Count == 0)
                return false;
            else
                return true;
        }

        public static bool HasPhoneInBD(string phone)
        {
            var userList = (from user in db.users
                            where user.phone == phone
                            select user).ToList();
            if (userList.Count == 0)
                return false;
            else
                return true;
        }

        public static User GetUser(string login, string password)
        {
            string hashPass = GetHash(password);
            var user = (from u in db.users
                            where (u.email == login || u.phone == login) && u.pass == hashPass
                        select u).First();

            return new User(
                user.user_id,
                user.surname,
                user.name,
                user.lastname,
                user.phone,
                user.email,
                password,
                user.status,
                user.about_your_self);
        }

        public static void AddConference(string name, string subject, DateTime dateTime, string place, int countSpeakers, int countGuests, TimeSpan time)
        {
            // Создание новой конференции
            try
            {
                conf conference = new conf
                {
                    name = name,
                    subject = subject,
                    data = dateTime,
                    place = place,
                    count_speakers = countSpeakers,
                    count_guests = countGuests,
                    starttime = time
                };
                db.conf.Add(conference);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка добавления конференции");
            }
        }

        public static List<conf> GetAllConferences()
        {
            // Взятие из БД всех конференций в порядке: сначала ближайшие будущие, потом все прошлые
            try
            {
                var confListWill = (from c in db.conf
                                    where c.data >= DateTime.Now
                                    orderby c.data
                                    orderby c.starttime
                                    select c).ToList();
                var confListWas = (from c in db.conf
                                   where c.data < DateTime.Now
                                   orderby c.data
                                   orderby c.starttime
                                   select c).ToList();
                confListWill.AddRange(confListWas);
                return confListWill;
            }
            catch
            {
                MessageBox.Show("Ошибка обновления конференций");
                return new List<conf>();
            }
        }


        public static List<conf> GetFutureConferences(int userId)
        {
            // Взятие из БД будущих конференций 
            try
            {
                var confListWill = (from c in db.conf
                                    where c.data >= DateTime.Now
                                    orderby c.data
                                    orderby c.starttime
                                    select c).ToList();
                var myConfs = GetMyConferences(userId);
                for(int i =  0; i < confListWill.Count; i++)
                {
                    if (myConfs.Contains(confListWill[i]))
                    {
                        confListWill.Remove(confListWill[i]);
                        i--;
                    }
                }
                return confListWill;
            }
            catch
            {
                MessageBox.Show("Ошибка обновления конференций");
                return new List<conf>();
            }
        }

        public static List<conf> GetMyConferences(int userId)
        {
            // Взятие из БД конференций, на которое он записан 
            try
            {
                var confListWill = (from c in db.conf
                                    join r in db.records on c.conf_id equals r.conf_id
                                    where c.data >= DateTime.Now
                                    && r.user_id == userId
                                    orderby c.data
                                    orderby c.starttime
                                    select c).ToList();
                return confListWill;
            }
            catch
            {
                MessageBox.Show("Ошибка обновления конференций");
                return new List<conf>();
            }
        }



        public static void EditConference(int confId, string newName, string newSubject, DateTime newDateTime, string newPlace, int newCountSpeakers, int newCountGuests, TimeSpan newTime)
        {
            try
            {
                var confToChange = db.conf.Where(c => c.conf_id == confId).First();
                confToChange.name = newName;
                confToChange.subject = newSubject;
                confToChange.data = newDateTime;
                confToChange.place = newPlace;
                confToChange.count_speakers = newCountSpeakers;
                confToChange.count_guests = newCountGuests;
                confToChange.starttime = newTime;
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения данных");
            }
        }


        public static void DeleteConference(int confId)
        {
            try
            {
                var conference = db.conf.Where(c => c.conf_id == confId).First();
                var recodList = (from r in db.records
                                 where r.conf_id == confId
                                 select r).ToList();
                db.records.RemoveRange(recodList);


                db.conf.Remove(conference);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось удалить конференцию");
            }
        }








        public static users GetUserById(int id)
        {
            try
            {
                var user = (from u in db.users
                            where u.user_id == id
                            select u).First();
                return user;
            }
            catch
            {
                MessageBox.Show("Ошибка запроса нахождения пользователя");
                return null;
            }
        }

        public static List<users> GetGuestsRegistrationList(int condId)
        {
            List<users> userList = new List<users>();
            try
            {
                var usersIdList = (from r in db.records
                                where r.conf_id == condId
                                && r.topic == null
                                select r.user_id).ToList();
                foreach(int userId in usersIdList)
                {
                    userList.Add(GetUserById(userId));
                }
                 

                return userList;
            }
            catch
            {
                MessageBox.Show("Ошибка запроса");
                return userList;
            }
        }

        public static List<users> GetSpeakersRegistrationList(int condId)
        {
            List<users> userList = new List<users>();
            try
            {
                var usersIdList = (from r in db.records
                                where r.conf_id == condId
                                && r.topic != null
                                select r.user_id).ToList();
                foreach (int userId in usersIdList)
                {
                    userList.Add(GetUserById(userId));
                }

                return userList;
            }
            catch
            {
                MessageBox.Show("Ошибка запроса");
                return userList;
            }
        }



        public static void EditUser(int userId, string newSurname, string newName, string newLastName, string newPhone, string newMail, string newPass, string aboutYourSelf)
        {
            try
            {
                var user = (from u in db.users
                            where u.user_id == userId
                            select u).First();
                user.surname = newSurname;
                user.name = newName;
                user.lastname = newLastName;
                user.phone = newPhone;
                user.email = newMail;
                user.pass = GetHash(newPass);
                user.about_your_self = aboutYourSelf;
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка запроса, данные не сохранены");
            }
        }

        public static void AddUser( string surname, string name, string lastName, string phone, string email, string pass, int status, string aboutYourSelf)
        {
            try
            {
                users user = new users
                {
                    surname = surname,
                    name = name,
                    lastname = lastName,
                    phone = phone,
                    email = email,
                    pass = GetHash(pass),
                    status = status,
                    about_your_self = aboutYourSelf
                };
                db.users.Add(user);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка, пользователь не создан");
            }
        }

        public static void RegisterToConference(int userId, int confId, string topic)
        {
            try
            {
                records record = new records
                {
                    user_id = userId,
                    conf_id = confId,
                    topic = topic
                };
                db.records.Add(record);
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        MessageBox.Show("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
        }

        public static void RemoveMyConference(int userId, int confId)
        {
            try
            {
                var rec = (from r in db.records
                           where r.user_id == userId
                           && r.conf_id == confId
                           select r).First();
                db.records.Remove(rec);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка, запись не удалена");
            }

        }
    }
}

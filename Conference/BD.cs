using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference
{
    static class BD
    {
        static ConferenceEntities1 db = new ConferenceEntities1();

        public static int GetStatus(string login, string password)
        {
            // Метод возвращвет статус аккаунта или -1, при его отсутствии
            try
            {
                var userList = (from user in db.users
                                where user.email == login && user.pass == password
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

        public static bool LoginIsTrue(string login)
        {
            var userList = (from user in db.users
                            where user.email == login
                            select user).ToList();
            if (userList.Count == 0)
                return false;
            else
                return true;
        }
        public static Admin GetAdmin(string login, string password)
        {
            var admin = (from user in db.users
                            where user.email == login && user.pass == password
                            select user).First();

            return new Admin(
                admin.user_id,
                admin.phone,
                admin.email,
                admin.pass);
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


    }
}

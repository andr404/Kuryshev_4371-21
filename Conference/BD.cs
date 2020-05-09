using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{
    static class BD
    {
        static ConferenceEntities conf = new ConferenceEntities();

        public static int GetStatus(string login, string password)
        {
            var userList = (from user in conf.users
                          where user.email == login && user.pass == password
                          select user).ToList();
            if (userList.Count == 0)
                return -1;
            else
                return userList[0].status;
        }
    }
}

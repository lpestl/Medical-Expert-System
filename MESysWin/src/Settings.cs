using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MESysWin.GUI;

namespace MESysWin.src
{
    class Settings
    {
        private static Settings instance;

        private Settings()
        {
            Logout();            
        }

        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Settings();
                    Log.Print("Create Settings instance singletone", "Settings", Log.type.INFO);
                }
                return instance;
            }
        }

        public User currenUser;

        public void Logout()
        {
            currenUser = new User();
            currenUser.Login = "Гость";
            currenUser.GroupId = 1;
        }

        public bool Login(string login, string password)
        {
            bool res = false;

            var list = DatabaseManager.Instance.GetUserList();
            foreach (var usr in list)
            {
                if ((usr.Login.Equals(login)) && (usr.Password.Equals(password)))
                {
                    res = true;
                    currenUser = usr;
                    break;
                }
            }

            return res;
        }
    }
}

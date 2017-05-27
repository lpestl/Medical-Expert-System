using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public class User
    {
        public long ID { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public long GroupId { get; set; } 

        public User()
        {
            ID = -1;
            Login = String.Empty;
            Password = String.Empty;
            GroupId = 1;
        }

        public string LastTrouble { get; set; }
        public bool CheckData()
        {
            if (Login == null)
            {
                LastTrouble = "Login == null";
                return false;
            }

            if (Login.Length == 0)
            {
                LastTrouble = "Login is empty";
                return false;
            }
            
            var list = DatabaseManager.Instance.GetUserList();
            var listMatch = list.FindAll(x => x.Login == Login);
            try
            {
                foreach (var u in listMatch)
                {
                    if (u.ID != ID)
                    {
                        LastTrouble = "Login is busy. Enter a different name.";
                        return false;
                    }
                }
            } catch
            {

            }
            
            return true;
        }
    }
}

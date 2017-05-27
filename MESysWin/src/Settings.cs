using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    class Settings
    {
        private static Settings instance;

        private Settings()
        {

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
    }
}

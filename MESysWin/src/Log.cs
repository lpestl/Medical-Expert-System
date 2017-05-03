using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    class Log
    {
        public static string lastLine;
        public enum type { INFO, WARNING, ERROR };
        public static void Print(string msg, string tag, type type_log) {
#if DEBUG
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"log.log", true))
            {
                string line;
                DateTime d = DateTime.Now;
                line = d.ToString("[yyyy.MM.dd-HH:mm:ss.fff]");
                switch (type_log)
                {
                    case type.INFO:
                        line += " [INFO] ";
                        break;
                    case type.WARNING:
                        line += " [WARNING] ";
                        break;
                    case type.ERROR:
                        line += " [ERROR] ";
                        break;
                    default:
                        break;
                }

                line += "[" + tag.ToUpper() + "] ";
                line += msg;
                file.WriteLine(line);

                lastLine = line;
            }
#endif
        }
    }
}

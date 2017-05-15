using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public enum BoundaryTypeEnum { LEFT, RIGHT, MIDDLE };

    public class BoundaryType
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public BoundaryType(long id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }

        public string LastTrouble { get; set; }
        public bool CheckData()
        {
            if (ID < 0)
            {
                LastTrouble = "ID < 0.";
                return false;
            }
            if (Name == null)
            {
                LastTrouble = "Name is null.";
                return false;
            }
            if (Name.Length == 0)
            {
                LastTrouble = "Name is empty.";
                return false;
            }

            return true;
        }
    }
}

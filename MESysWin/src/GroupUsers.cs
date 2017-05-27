using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public class GroupUsers
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public GroupUsers()
        {
            ID = -1;
            Name = String.Empty;
            Description = String.Empty;
        }
    }
}

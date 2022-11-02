using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Example
{
    internal class Event_1
    {
        public delegate void WhichNameDel(string name);
        public event WhichNameDel WhichName_handler;
        public void Run(string name)
        {
            if ( WhichName_handler != null )
                WhichName_handler(name);
        }
    }
}

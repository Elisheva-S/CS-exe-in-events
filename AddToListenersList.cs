using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Example
{
    internal class AddToListenersList
    {
        public void Add(string name)
        {
            Event_1 event_ = new Event_1();
            Form1 form1 = new Form1();
            event_. WhichName_handler += form1.Check;
            event_.Run(name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WorkPerformedEventArgs : System.EventArgs
    {

        public WorkPerformedEventArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = workType;
        }

        // prop tab tab!
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}

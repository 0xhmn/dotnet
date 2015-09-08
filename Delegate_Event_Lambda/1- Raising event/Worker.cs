using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * compare these two: (WorkPerformedEventArgs is a class for Args)
 * 1- public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs e);
 * 2- public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
 */
namespace ConsoleApplication1
{
    /**
     (1) FIRST APPROACH: defining a delegate
     NOTE:
     This way will work, but it's not standard method
     we should give this delegate an object and EventArg
     */
//    public delegate int WorkPerformedHandler(int hours, WorkType workType);
    /* (2) SECOND APPROACH: new delegate, using WorkPerformedEventArgs */
    public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);


    class Worker
    {    
         /**
         * (3) THIRD APPROACH
         * to eliminate the delegate entirely
         */
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed2;


        // EVNET
        public event WorkPerformedHandler WorkPerformed;
        // event handler
        public event EventHandler WorkCompleted;

        // BUILT-IN DELEGATE: EVENTHANDLER
        public virtual void DoWork(int hours, WorkType workType)
        {
            // report every one hour
            for (int i = 0; i < hours; i++)
            {
                // raise event (workPerformed)
                OnWorkPerformed(i + 1, workType);
                System.Threading.Thread.Sleep(300);
            }
            // rais event (workCompleted)
            OnWorkCompleted();
        }

        // raise OnWorkPerformed event
        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            // FIRST METHOD (LIKE A METHOD)
            /*
            if (WorkPerformed != null)
            {
                WorkPerformed(hours, workType);
            }
             */

            // SECOND METHOD (casting the delegate)
            // check to see if delegate is empty
            WorkPerformedHandler del = WorkPerformed as WorkPerformedHandler;
            if (del != null)
            {
                // raising the Event the old way:
                //del(hours, workType);

                // raising the Event with Args
                del(this, new WorkPerformedEventArgs(hours, workType));
            }
        }

        // raise OnWorkPerformed2 event
        protected virtual void OnWorkPerformed2(int hours, WorkType workType)
        {
            var del = WorkPerformed2 as EventHandler<WorkPerformedEventArgs>;
            if (del != null)
            {
                del(this, new WorkPerformedEventArgs(hours, workType));
            }
        }


        // raise OnWorkCompleted event (which uses EventHandler)
        // if we use EventHandler, we should define some EventArgs
        protected virtual void OnWorkCompleted()
        {
            EventHandler del = WorkCompleted as EventHandler;
            if (del != null)
            {
                // we should pass this class and EventArgument
                del(this, EventArgs.Empty);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * --- EVENT HANDLER---
 * 
 */
namespace ConsoleApplication1
{

//    public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);


    class Worker
    {
        // NOT WORKING WITH THIS EVENT
//        public event WorkPerformedHandler WorkPerformed2;

        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;


        public virtual void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
                System.Threading.Thread.Sleep(300);
            }
            OnWorkCompleted();
        }

        // NOT USING THIS EITHER
        //protected virtual void OnWorkPerformed2(int hours, WorkType workType)
        //{

        //    WorkPerformedHandler del = WorkPerformed2 as WorkPerformedHandler;
        //    if (del != null)
        //    {

        //        del(this, new WorkPerformedEventArgs(hours, workType));
        //    }
        //}


        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if (del != null)
            {
                del(this, new WorkPerformedEventArgs(hours, workType));
            }
        }



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

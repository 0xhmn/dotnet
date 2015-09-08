using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * EVENT HANDLING
 * 1- just like the event raiser, the event handler also need to have access to object "sender" and EventArgs
 * 2- steps:
 *      a. define the event (public event EventHandler<WorkPerformedEventArgs> WorkPerformed;)
 *      b. define onEvent(protected virtual void OnWorkPerformed(int hours, WorkType workType)
 *      c. make new object, register event with it and trigger the event
 *      
 */
namespace ConsoleApplication1
{


    class Program
    {
        static void Main(string[] args)
        {


            // WORKING WITH EVENTS IN WORKER.CS
            Worker worker = new Worker();
            // REGISTERING WORKER WITH WORKPERFORMED EVENT
            worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(worker_WorkPerformed);
            // REGISTERING WORKER WITH WORKCOMPLETED EVENT
            worker.WorkCompleted += new EventHandler(worker_WorkCompleted);
            // triger the event
            worker.DoWork(12,WorkType.GenerateReports);

            Console.Read();
        }

        static void worker_WorkPerformed(object sender, WorkPerformedEventArgs e ) {
            Console.WriteLine(e.Hours + " " + e.WorkType);
        }

        static void worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("work completed");
        }


    }
    // define WorkType enum
    public enum WorkType
    {
        Golf,
        GoToMeeting,
        GenerateReports
    }
}
    

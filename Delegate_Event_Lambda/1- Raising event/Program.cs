using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 0- we are defining the delegate in Works.cs
 * 1- if you concatenate some delegates together, the returning value will be for the last added delegate 
 * 
 * 2- before raising an event in c# make sure that there is nothing in its "delegate" or you'll get an exception
 * 3- invoking an event is just invoking the delegate behind the scnene
 * 4- another way to invoke event is casting the delegate and invoke it directly
 * 
 * 5- it is better to raise an event from a method with the prefix "On" + "delegate name"
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
            // REGISTERING WORKER WITH ONE EVENT


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
    

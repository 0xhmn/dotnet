using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event_Lambda
{
    delegate void showResult(int progress);

    class Delegate_Multicast
    {

        // slow process 
        public void slowSimulator(showResult show)
        {
            for (int i = 0; i < 10; i++)
            {
                show(i);
                // making the lag
                System.Threading.Thread.Sleep(300);
            }
        }
        // show on screen
        public void showOnScreen(int result)
        {
            Console.WriteLine(result);
        }
        // put in the file
        public void saveToFile(int result)
        {
            // first way
            //System.IO.File.WriteAllText("progress.txt", result.ToString());

            // second method
            //using (StreamWriter stream = File.AppendText("fileAppendText.txt"))
            //{
            //    stream.WriteLine(result);
            //}

            // third method
            System.IO.File.AppendAllText("anotherIOtest.txt", result + Environment.NewLine);
        }

    }
}

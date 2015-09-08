using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Event
    {
        public static void Main()
        {
            Person p = new Person();
            // register it to the event
            p.cashEvenet += p_cashEvent;

            p.addCash(50);
            p.addCash(60);

            Console.ReadKey();
        }

        static void p_cashEvent()
        {
            Console.WriteLine("He has got more than 100");
        }
    }

    class Person
    {
        // a void delegate without argument
        public delegate void MyEventHandler();
        // an event
        public event MyEventHandler cashEvenet;

        private int cash;
        // defining a cash property
        public int Cash
        {
            get
            {
                return cash;
            }
            set
            {
                cash = value;
                if (cash >= 100)
                {
                    if (cashEvenet != null)
                    {
                        // call the event
                        cashEvenet();
                    }
                }
            }
        }

        // making a void to add to cash
        public void addCash(int amount)
        {
            Cash += amount;
        }
    }
}

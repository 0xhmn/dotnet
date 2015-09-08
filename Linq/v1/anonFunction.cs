using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    delegate void MyDel();
    class anonFunction
    {
        // annonymous function
        public static MyDel anfunct = delegate
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(i );
            }
        };



    }
}

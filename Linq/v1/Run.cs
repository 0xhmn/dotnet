using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// xml
using System.Xml.Linq;

namespace Linq
{
    class Run
    {
        public static void Main() {
            //enumerateTest.enumTest();
            //enumerateTest.enumTest2();
            //enumerateTest.enumTest3();
            //enumerateTest.enumTest4();

            //Console.WriteLine("from Linq class");
            //linq1.Linq2();
            //linq1.Linq3();

            // xml file
            // we've create the file with LinqXML.createData()
            // opening the file and reading the file
            LinqXML.saveData("sampleXML.xml");
            // loading the file
            XDocument doc = XDocument.Load("sampleXML.xml");
            LinqXML.queryData(doc);

            // pause
            Console.ReadKey();
        }
    }
}

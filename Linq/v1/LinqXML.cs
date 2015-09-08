using System;
using System.Linq;
using System.Xml.Linq;

namespace Linq
{
    class LinqXML
    {
        // making an XML file
        public static XDocument createData()
        {
            XDocument cdData = new XDocument(
                // adding declarations
                new XDeclaration("1.0", "utf8", "yes"),
                // adding a sample comment
                new XComment("this is a sample comment here!"),
                // adding parent element
                new XElement("CDNumber1",
                    // adding attributes
                    new XAttribute("id", "one"),
                    // new elements as the childes
                    new XElement("Title", "Love Gun"),
                    new XElement("Artist", "Kiss"),
                    new XElement("Genre", "Rock"),
                    new XElement("SaleInfo",
                        new XElement("Price", 11.99),
                        new XElement("Store", "everywhere"),
                        new XElement("Qty", 5)))
                );
            return cdData;
        }

        // saving xml data to a file
        // will create a file inside the bin/Debug
        public static void saveData(string filename)
        {
            XDocument document = createData();
            document.Save(filename);
        }

        // getting the data from xml file
        public static void queryData(XDocument doc)
        {
            var data = from item in doc.Descendants("CDNumber1")
                       select new
                       {
                           CdTitle = item.Element("Title").Value,
                           CdArtist = item.Element("Artist").Value,
                           Price = item.Element("SaleInfo").Element("Price").Value
                       };
            foreach (var s in data) { Console.WriteLine(s.ToString()); }

        }
    }
}

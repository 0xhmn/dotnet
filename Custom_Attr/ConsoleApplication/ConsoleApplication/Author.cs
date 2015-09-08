using System;

namespace ConsoleApplication
{
    class Author : Attribute
    {
        public Author(string name)
        {
            this.Name = name;
            this.Version = 1.0;
        }

        private string Name { get; set; }
        public double Version { get; set; }

    }
}

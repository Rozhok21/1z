using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yn
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("cgjg", "gjgjgvj", 2000);
        }
        public class Library
        {
            public string Name { get; set; }
            public string Adress { get; set; }
            public int Year { get; set; }
            public Library(string Name, string Adress, int Year)
            {
                this.Name = Name;
                this.Adress = Adress;
                this.Year = Year;

            }
        }
    }
}

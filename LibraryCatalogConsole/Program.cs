using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    class Program
    {
        public static Library<Book> catalog = new Library<Book>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fellow Biblophile! Weclome to The Library!");

            catalog.Query();

            Console.WriteLine("\nThank you for visiting! Please come back again soon!\n");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }

    }
}

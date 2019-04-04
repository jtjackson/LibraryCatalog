using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace LibraryCatalog
{
    public class Library<Book>
    {
        public static List<LibraryCatalog.Book> BookList;
        public static bool no_exit = true;
        private static readonly string jsonfile = "../../json/books.json";

        public Library()
        {
            BookList = GetLibraryCollection();
        }

        internal List<LibraryCatalog.Book> GetLibraryCollection()
        {     
            List<LibraryCatalog.Book> book_1 = new List<LibraryCatalog.Book>();
            return DeSerializeJSON(book_1);            
        }

        private List<LibraryCatalog.Book> DeSerializeJSON(List<LibraryCatalog.Book> json_book)
        {
            StreamReader file = File.OpenText(jsonfile);
            string json = file.ReadToEnd();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            
            DataContractJsonSerializer ser = new DataContractJsonSerializer(json_book.GetType());
            json_book = ser.ReadObject(ms) as List<LibraryCatalog.Book>;
            ms.Close();

            return json_book;
        }

        internal void Query()
        {
            while (no_exit)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Browse the collection ");
                Console.WriteLine("2. Seach for a book by title");
                Console.WriteLine("3. Seach for a book by author ");
                Console.WriteLine("4. Quit ");

                var answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        BrowseCollection(BookList);
                        break;
                    case "2":
                        SearchForBookByTitle();
                        break;
                    case "3":
                        SearchForBooksByAuthor();
                        break;
                    case "4":
                        no_exit = false;
                        break;
                    default:
                        break;

                }
            }
        }

        internal void BrowseCollection(List<LibraryCatalog.Book> bookList)
        {
            Console.WriteLine("\n{0, -50} {1,-30} {2, -20} {3,-30} {4,-30}\n", "Title", "Author", "Pages", "Language", "Country");
           
            foreach (LibraryCatalog.Book book in bookList)
            {
                Console.WriteLine("{0, -50} {1,-30} {2,-20} {3,-30} {4,-30}", book.title, book.author, book.pages, book.language, book.country);
            }
        }

        internal void SearchForBookByTitle()
        {
            Console.Write("\nTitle of book you want to look for: ");
            var what_book = Console.ReadLine();

            List<LibraryCatalog.Book> brklist = BookList.FindAll(bk => bk.title.ToUpper().Contains(what_book.ToUpper()));

            if (brklist.Count > 0)
            {
                BrowseCollection(brklist);
            }
            else
                Console.WriteLine("Sorry! No books with the title '{0}' found!", what_book);
        }

        internal void SearchForBooksByAuthor()
        {
            Console.Write("\nName of Author you want to look for: ");
            var what_author = Console.ReadLine();

            List<LibraryCatalog.Book> brklist = BookList.FindAll(bk => bk.author.ToUpper().Contains(what_author.ToUpper()));

            if (brklist.Count > 0)
            {
                BrowseCollection(brklist);
            }
            else
                Console.WriteLine("Sorry! No books by '{0}' found!", what_author);
        }
    }
}

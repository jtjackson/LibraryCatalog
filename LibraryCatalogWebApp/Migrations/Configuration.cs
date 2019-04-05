namespace LibraryCatalogWebApp.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Json;
    using System.Text;
    using LibraryCatalogWebApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CatalogContext>
    {
        private static readonly string jsonfile = "C:\\Users\\jjackson\\source\\repos\\LibraryCatalog\\LibraryCatalogConsole\\json\\books.json";

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LibraryCatalogWebApp.Models.CatalogContext context)
        {
            List<Book> book_list = GetLibraryCollection();

            foreach(Book book in book_list)
                context.Books.AddOrUpdate(book);
        }
        
        internal List<Book> GetLibraryCollection()
        {
            List<Book> book_1 = new List<Book>();
            return DeSerializeJSON(book_1);
        }

        private List<Book> DeSerializeJSON(List<Book> json_book)
        {
            StreamReader file = File.OpenText(jsonfile);
            string json = file.ReadToEnd();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));

            DataContractJsonSerializer ser = new DataContractJsonSerializer(json_book.GetType());
            json_book = ser.ReadObject(ms) as List<Book>;
            ms.Close();

            return json_book;
        }
    }
}

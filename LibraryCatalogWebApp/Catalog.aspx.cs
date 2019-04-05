using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryCatalogWebApp.Models;

namespace LibraryCatalogWebApp
{
    public partial class Catalog : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Book> booksGrid_GetData()
        {
            CatalogContext db = new CatalogContext();
            var query = db.Books;
            return query;
        }

        protected void getBooksByAuthor(object sender, EventArgs e)
        {
           // CatalogContext db = new CatalogContext();
            //IQueryable<Book> query = db.Books.Include();
        }

        protected void getBooksByTitle(object sender, EventArgs e)
        { }

        public IQueryable<Book> _getBooksByAuthor()
        {
            CatalogContext db = new CatalogContext();
            var query = db.Books;
            return query;
        }

        public IQueryable<Book> _getBooksByTitle()
        {
            CatalogContext db = new CatalogContext();
            var query = db.Books;
            return query;
        }
    }
}
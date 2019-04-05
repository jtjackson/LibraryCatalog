using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryCatalogWebApp.Models;
using System.Data.Entity;
using System.Web.ModelBinding;

namespace LibraryCatalogWebApp
{
    public partial class Catalog : Page
    {
        CatalogContext db = new CatalogContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            db.Books.Load();
            //this.booksGrid.DataSource = db.Books.Local.ToBindingList();

        }
        public IQueryable<Book> booksGrid_GetData()
        {
            
            var query = db.Books;
            return query;
        }

    }
}
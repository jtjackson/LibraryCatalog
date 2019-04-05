using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace LibraryCatalogWebApp.Models
{
    public class CatalogContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }

    [DataContract]
    public class Book
    {
        [Key, Display(Name = "ID")]
        public int BookID { get; set; }
        [DataMember, Display(Name ="Title")]
        public string title { get; set; }
        [DataMember, Display(Name = "Author")]
        public string author { get; set; }
        [DataMember, Display(Name = "Pages")]
        public string pages { get; set; }
        [DataMember, Display(Name = "Year")]
        public string year { get; set; }
        [DataMember, Display(Name = "Language")]
        public string language { get; set; }
        [DataMember, Display(Name ="Country")]
        public string country { get; set; }
    }
}
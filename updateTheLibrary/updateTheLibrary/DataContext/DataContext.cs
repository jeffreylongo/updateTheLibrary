using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using updateTheLibrary.Models;

namespace updateTheLibrary.DataContext
{
    public class DataContext :DbContext
    {
        public DataContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
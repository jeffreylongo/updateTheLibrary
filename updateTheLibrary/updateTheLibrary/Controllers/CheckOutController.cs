using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using updateTheLibrary.DataContext;
using updateTheLibrary.Models;

namespace updateTheLibrary.Controllers
{
    public class CheckOutController : ApiController
    {
        private DataContext.DataContext db = new DataContext.DataContext();

        //check out book
        public Book CheckOut(int id)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return null;
            }
            else
            {
                book.IsCheckedOut = true;
            }
            return book;
        }

        //check in book
        public Book CheckIn(int id)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return null;
            }
            else
            {
                book.IsCheckedOut = false;
            }
            return book;
        }

        //get all checked out books
        public IQueryable<Book> GetCheckedBooks()
        {
            return db.Books.Where(b => b.IsCheckedOut == true);
        }

    }
}
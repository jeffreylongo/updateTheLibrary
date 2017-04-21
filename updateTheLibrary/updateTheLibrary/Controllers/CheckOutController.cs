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

        // GET: 
        public IQueryable<Book> GetBooks()
        {
            return db.Books;
        }

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
                book.LastCheckedOutDate = DateTime.Now;
                book.DueBackDate = DateTime.Now.AddDays(10);
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
                book.DueBackDate = null;
            }
            return book;
        }

        //get all checked out books
        public IQueryable<Book> GetCheckedBooks()
        {
            return db.Books.Where(b => b.IsCheckedOut == true);
        }

        //get all available books
        public IQueryable<Book> GetAvailableBooks()
        {
            return db.Books.Where(b => b.IsCheckedOut == false);
        }
    }
}
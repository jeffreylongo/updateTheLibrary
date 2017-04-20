namespace updateTheLibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using updateTheLibrary.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<updateTheLibrary.DataContext.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(updateTheLibrary.DataContext.DataContext context)
        {
            var books = new System.Collections.Generic.List<Models.Book>
            {
                new Models.Book{ Title="It", Author="Stephen King",
                                YearPublished=1986, Genre="Horror", IsCheckedOut=false,
                                LastCheckedOutDate=null, DueBackDate =null}
            };
            context.Books.AddOrUpdate(a => a.Title, books.First());
            context.SaveChanges();
        }
    }
}

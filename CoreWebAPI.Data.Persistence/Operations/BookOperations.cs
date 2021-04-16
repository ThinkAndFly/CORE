using CoreWebAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebAPI.Data.Persistence.Operations
{
    public class BookOperations : ContextService
    {
        public string GetName(int id)
        {
            return MyDbContext.Bookshelf.Find(id).Title;
        }

        public bool NewBook(string title)
        {
            var new_book = new Book() { Title = title };
            MyDbContext.Bookshelf.Add(new_book);
            MyDbContext.SaveChanges();
            return true;
        }
    }
}

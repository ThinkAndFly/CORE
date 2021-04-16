using CoreWebAPI.Data.Persistence.Operations;
using System;

namespace CoreWebAPI.Domain
{
    public class BookDomain
    {
        public string GetName(int id)
        {
            return new BookOperations().GetName(id);
        }

        public bool NewBook(string title)
        {
            return new BookOperations().NewBook(title);
        }
    }
}

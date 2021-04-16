using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebAPI.Data.Persistence
{
    public class ContextService : IDisposable
    {
        private bool disposed = false;
        private bool _isContextInternal;
        private APIDbContext _myDbContext;

        public ContextService()
        {
            _myDbContext = new APIDbContext();
            _isContextInternal = true;
        }

        public ContextService(APIDbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException();
            }
            _myDbContext = dbContext;
            _isContextInternal = false;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                }
                if (_isContextInternal)
                {
                    _myDbContext.Dispose();
                }
                disposed = true;
            }
        }

        ~ContextService()
        {
            Dispose(false);
        }

        public APIDbContext MyDbContext
        {
            get
            {
                return _myDbContext;
            }
        }
    }
}

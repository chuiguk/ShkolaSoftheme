using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class ResourceHolderBase : IDisposable
    {
        bool _disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~ResourceHolderBase()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Dispose from ResourceHolderBase");
                }
                _disposed = true;
            }
        }
    }
}

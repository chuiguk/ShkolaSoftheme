using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class ResourceHolderDerived : ResourceHolderBase
    {
        bool _disposed = false;
        ~ResourceHolderDerived()
        {
            Dispose(false);
        }
        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Dispose from ResourceHolderDerived");
                }
                _disposed = true;
            }
            base.Dispose(disposing);
        }
    }
}

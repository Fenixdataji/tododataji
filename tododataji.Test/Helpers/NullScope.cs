using System;
using System.Collections.Generic;
using System.Text;

namespace tododataji.Test.Helpers
{
    class NullScope : IDisposable
    {
        public void Dispose(){ }
        public  static NullScope  Instance{ get; } = new NullScope();

        private NullScope() { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPool {
  class ThreadPool {
    internal ThreadPool() {
      Task.Factory.StartNew(TestWriteLine);
    }

    private void TestWriteLine() {
      Console.WriteLine("This is thread pool.");
    }
  }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPool.TestClass {
  class BeginThreadPool {
    private Task _task;
    internal BeginThreadPool() {
      _task = Task.Factory.StartNew(TestWriteLine);
      Console.WriteLine("1 " + _task.Status);
      _task.Wait();
      Console.WriteLine("3 " + _task.Status);
    }

    private void TestWriteLine() {
      Console.WriteLine("2 " + _task.Status);
      Console.WriteLine("This is thread pool.");
    }
  }
}

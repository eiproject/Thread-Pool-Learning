using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPool.TestClass {
  class TaskTResult {
    internal TaskTResult() {
      // Start the task executing:
      Task<string> task = Task.Factory.StartNew<string>
        (() => DownloadString("http://www.linqpad.net"));

      // We can do other work here and it will execute in parallel:
      RunSomeOtherMethod();

      // When we need the task's return value, we query its Result property:
      // If it's still executing, the current thread will now block (wait)
      // until the task finishes:
      string result = task.Result;
      Console.WriteLine($"Result OK: {result.Length} words downloaded.");
    }

    private void RunSomeOtherMethod() {
      Console.WriteLine("... Just another method ...");
    }

    private string DownloadString(string uri) {
      using (var wc = new System.Net.WebClient())
        return wc.DownloadString(uri);
    }
  }
}

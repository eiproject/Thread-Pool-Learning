using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadPoolNetFramework.TestClass {
  class AsynchronousDelegates {
    internal AsynchronousDelegates() {
      Func<string, int> method = Work;
      IAsyncResult cookie = method.BeginInvoke("test", null, null);
      //
      // ... here's where we can do other work in parallel...
      //
      int result = method.EndInvoke(cookie);
      Console.WriteLine("String length is: " + result);
    }

    static int Work(string s) { return s.Length; }
  }
}

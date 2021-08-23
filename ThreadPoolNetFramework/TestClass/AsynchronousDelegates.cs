using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadPoolNetFramework.TestClass {
  class AsynchronousDelegates {
    private Func<string, string, int> _delegateMethod;
    private IAsyncResult _invoked;
    internal AsynchronousDelegates() {
      _delegateMethod = Work;
      _invoked = _delegateMethod.BeginInvoke("great", "good", null, null);
      
      // _invoked = _delegateMethod.BeginInvoke("bad", "worse", null, null);

      int result = _delegateMethod.EndInvoke(_invoked);
      Console.WriteLine("String length is: " + result);
    }

    private int Work(string s, string t) {
      return s.Length + t.Length;
    }
  }
}

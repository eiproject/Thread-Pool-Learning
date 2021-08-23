using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPoolNetFramework.TestClass {
  class AsynchronousDelegatesCookieMethod {
    internal AsynchronousDelegatesCookieMethod() {
      Func<string, int> method = Work;
      method.BeginInvoke("test", Done, method);
    }

    static int Work(string s) { return s.Length; }

    static void Done(IAsyncResult cookie) {
      Func<string, int> target = (Func<string, int>)cookie.AsyncState;
      int result = target.EndInvoke(cookie);
      Console.WriteLine("String length is: " + result);
    }
  }
}

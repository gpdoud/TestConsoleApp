using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp {
    class TestException : Exception {
        public TestException() : base() {}
        public TestException(string message) : base(message) { }
        public TestException(string message, Exception innerException) : base(message, innerException) { }
    }
    class DemoExceptions {
        public void run() {
            try {
                var a = 0;
                if(a == 0) {
                    /*
                     * You "throw new" when your code is generating an exception
                     */
                    //throw new TestException("a is zero");
                }
                var b = 1;
                var c = b / a;
            } catch(DivideByZeroException ex) {
                /*
                 * You simply "throw" when you catch an exception that cannot 
                 * be handled and you want to allow the exception to continue
                 * to bubble up
                 */
                throw;
            } catch(TestException ex) { 
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

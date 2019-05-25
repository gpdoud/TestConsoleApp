using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp {
    interface IPrintable {
        void Print();
    }
    abstract class Printable {
        public abstract void Print();
    }
}

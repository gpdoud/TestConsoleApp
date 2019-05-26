using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp {

    class x { }
    class a : x { }
    class b : x { }
    class c : x { }

    class FactoryDesignPattern {

        public static void run() {
            // create an instance of class a
            var a = CreateInstance(0);
            var b = CreateInstance(1);
            var c = CreateInstance(2);
        }

        public static x CreateInstance(int i) {
            switch(i) {
                case 0: return new a();
                case 1: return new b();
                case 2: return new c();
                default: return null;
            }
        }
        private FactoryDesignPattern() { }
    }
}

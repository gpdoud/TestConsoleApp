using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp.DI {
    class Quack : ISound {

        public void MakeSound() {
            Console.WriteLine("Quack");
        }
    }
}

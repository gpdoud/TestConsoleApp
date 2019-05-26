using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp.DI {
    class QuackQuack : ISound {

        public void MakeSound() {
            Console.WriteLine("Quack; Quack");
        }

    }
}

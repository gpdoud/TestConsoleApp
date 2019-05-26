using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp.DI {
    class Bark : ISound {

        public void MakeSound() {
            Console.WriteLine("Bark");
        }
    }
}

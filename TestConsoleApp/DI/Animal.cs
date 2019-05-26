using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp.DI {
    class Animal : IAnimal {

        public string Name { get; set; }
        private ISound sound { get; set; }

        public void MakeSound() {
            sound.MakeSound();
        }

        public Animal(ISound sound) {
            this.sound = sound;
        }

        public void run() {

        }
    }
}

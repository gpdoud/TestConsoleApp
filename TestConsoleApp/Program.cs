using System;
using System.Collections.Generic;
using TestConsoleApp.DI;

namespace TestConsoleApp {
    class Program {
        static void Main(string[] args) {

            Animal duck = new Animal(new Quack());
            duck.MakeSound();
            Animal dog = new Animal(new Bark());
            dog.MakeSound();
            Animal studderingDuck = new Animal(new QuackQuack());
            studderingDuck.MakeSound();

            /*
             * This is an example of using a class in a compiled assembly as
             * a base class for inheritance. The class in the compiled assembly
             * can be used even thought the source is not available.
             */
            InheritingAssemblyClass iac = new InheritingAssemblyClass();
            iac.WriteHelloName("Greg Doud");
            /*
             * This is an example of using Reflection to call a method in a
             * compiled assembly.
             */
            Reflection.run();
            /*
             * This is an example of using the Factory Design Pattern to create
             * an instance of one of three classes. This design pattern is useful 
             * especially when the constructors for the classes to be instantiated
             * are complete (i.e. take many and different parameters)
             */
            FactoryDesignPattern.run();
            /*
             * This is an example of the difference between using a "throw" and
             * a "throw new". The "throw new" is used within code to create a new
             * instance of an exception. The "throw" is used within a catch block
             * after an exception is caught but when it cannot be handled, it is 
             * rethrown to continue bubbling up through the stack
             */
            DemoExceptions demo = new DemoExceptions();
            demo.run();

            List<Account> accounts = new List<Account>();

            //accounts.Add(new Account());
            accounts.Add(new Savings());

            foreach(var account in accounts) {
                account.Print();
            }
        }
    }
    abstract class Account {
        public virtual void Print() {
            Console.WriteLine("Account");
        }
        public abstract void Write();
        /// <summary>
        /// The Print method is overloaded if the name occurs more
        /// than once but the parameter lists differ by type and position
        /// </summary>
        /// <param name="message"></param>
        public void Print(string message) {

        }
    }
    class Savings : Account {
        public override void Print() {
            Console.WriteLine("Savings");
        }

        public override void Write() {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// Checking IMPLEMENTS IPrintable because it is an interface
    /// Checking MUST create every method defined in the interface
    /// </summary>
    class Checking : IPrintable {
        public void Print() {

        }
    }
}

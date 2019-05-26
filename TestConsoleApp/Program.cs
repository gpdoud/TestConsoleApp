using System;
using System.Collections.Generic;

namespace TestConsoleApp {
    class Program {
        static void Main(string[] args) {

            Reflection.run();

            FactoryDesignPattern.run();

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

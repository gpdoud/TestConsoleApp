using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TestConsoleApp {
    class Reflection {

        public static void run() {
            var pathToExe = @"C:\repos\ken\TestConsoleApp\ExeForReflection\bin\Debug\ExeForReflection.exe";
            Assembly asm = Assembly.LoadFile(pathToExe);
            Type t = asm.GetType("ExeForReflection.Program");
            object o = Activator.CreateInstance(t);
            var methodInfo = t.GetMethod("WriteHelloName", new Type[] { typeof(string) });
            if(methodInfo == null) {
                throw new Exception("WriteHelloName method is not found!");
            }
            object[] parameters = { "Gregory Patrick Doud" };
            methodInfo.Invoke(o, parameters);
        }

    }
}

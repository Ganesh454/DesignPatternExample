using System;

namespace SingletonPatternExample
{
    // sealed keyword also restrict inheritance of this class in other class & nested class
    // Whenever we defined a class within another class in C# then the inner class is called a nested class or child class
    public sealed class LogManager
    {
        private static int counter = 0;
        
        // private constructor will help to not  inherit this class
        private LogManager()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        // Eager loading in singleton design pattern is nothing a process in which we need to initialize the singleton object at
        // the time of application start-up rather than on-demand and keep it ready in memory to be used in the future.
        // The advantage of using Eager Loading in the Singleton design pattern is that the CLR (Common Language Runtime)
        // will take care of object initialization and thread-safety.
        // That means we will not require to write any code explicitly for handling the thread-safety for a multithreaded environment.

        // private static readonly Singleton singleInstance = new Singleton(); 

        // lazy keyword which was introduced as part of .NET Framework 4.0 provides the built-in support for lazy initialization i.e. on-demand object initialization
        private static readonly Lazy<LogManager> Instancelock =
                    new Lazy<LogManager>(() => new LogManager());
        public static LogManager GetInstance
        {
            get
            {
                return Instancelock.Value;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

  
}

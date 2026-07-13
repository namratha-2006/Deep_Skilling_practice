using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        // Single instance
        private static Logger instance;

        // Private constructor
        private Logger()
        {
        }

        // Public method to access instance
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }
}
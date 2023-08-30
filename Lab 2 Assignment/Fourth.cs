using System;
namespace Lab24
{
    class Logger
    {
        public void LogMessage()
        {
            Console.WriteLine("This is the example of Static class");
        }
        public static void Main(string[] args)
        {
            Logger l = new Logger();
            l.LogMessage();
        }
    }
}
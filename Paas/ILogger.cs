using System;

namespace Paas
{
    public interface ILogger
    {
        void LogMessage();
    }

    public class Logger : ILogger
    {
        public void LogMessage()
        {
            Console.Write("test");
        }
    }
}

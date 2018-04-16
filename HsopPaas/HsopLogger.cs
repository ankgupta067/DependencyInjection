using System;
using Paas;

namespace HsopPaas
{
    public class HsopLogger : ILogger
    {
        public void LogMessage()
        {
           var type = this.GetType().AssemblyQualifiedName;
            Console.WriteLine("Hsop Logger");
        }
    }
}

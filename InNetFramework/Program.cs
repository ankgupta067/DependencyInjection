using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paas;

namespace InNetFramework {
    class Program {
        static void Main(string[] args) {
            var logger = new Logger();
            logger.LogMessage();
            Console.Read();
        }
    }
}

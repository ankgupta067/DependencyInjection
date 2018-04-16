using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionInNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.Load("HsopPaas");
            var type = Type.GetType("HsopPaas.HsopLogger, HsopPaas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");
            Console.ReadLine();
        }
    }
}

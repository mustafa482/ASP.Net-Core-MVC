using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dependency_Injection.Services.Interface;

namespace Dependency_Injection.Services
{
    public class ConsoleLog:ILog
    {
        public ConsoleLog(int a)
        {

        }

        public void Log()
        {
            Console.WriteLine("Consoleda loglama edildi");
        }
    }
}

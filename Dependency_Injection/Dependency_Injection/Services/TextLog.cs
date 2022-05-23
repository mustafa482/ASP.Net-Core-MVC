using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dependency_Injection.Services.Interface;

namespace Dependency_Injection.Services
{
    public class TextLog:ILog
    {
        public void Log()
        {
            Console.WriteLine("Textde loglama edildi");
        }
    }
}

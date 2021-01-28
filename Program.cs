using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = Logger.GetInstance();

            log.logError("Execution start");
            log.logError("Execution end");

            Logger.closeLog();
            Console.ReadKey();
        }
    }
}

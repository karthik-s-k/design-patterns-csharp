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
            //Singleton design pattern is used for logging messages
            Logger log = Logger.GetInstance();

            log.logError("Execution start");

            Parallel.Invoke(
                    () => log.logError("Parallel invoke step 1"),
                    () => log.logError("Parallel invoke step 2"),
                    () => log.logError("Parallel invoke step 3")
                );

            log.logError("Execution end");
                        
            Console.ReadKey();
            Logger.closeLog();
        }
    }
}

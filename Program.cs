using System;
using System.Threading.Tasks;
using design_patterns_csharp.Strategy;
using design_patterns_csharp.Observer;
using System.Threading;

namespace design_patterns_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton design pattern is used for logging messages
            Logger log = Logger.GetInstance();

            log.logInfo("Program start");

            try
            {
                Parallel.Invoke(
                    () => Console.WriteLine("Parallel invoke step 1"),
                    () => Console.WriteLine("Parallel invoke step 2"),
                    () => Console.WriteLine("Parallel invoke step 3"),
                    () => Console.WriteLine("Parallel invoke step 4")
                );
            }
            catch(Exception ex)
            {
                log.logError(ex.Message);
            }            

            log.logInfo("Sorting start");

            //Strategy design pattern is used to sort the list
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            log.logInfo("Sorting using Quick sort");
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            log.logInfo("Sorting using Shell sort");
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            log.logInfo("Sorting using Merge sort");
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            log.logInfo("Sorting end");

            log.logInfo("Stock monitoring start");

            //Observer design pattern is used to notify listeners when stock prices change
            IBM ibm = new IBM("IBM", 120.00);
            Investor john = new Investor("John");
            Investor mary = new Investor("Mary");
            Investor chris = new Investor("Chris"); 
            Investor ana = new Investor("Ana");

            log.logInfo("Attaching John");
            ibm.Attach(john);
            log.logInfo("Attaching Mary");
            ibm.Attach(mary);
            log.logInfo("Attaching Chris");
            ibm.Attach(chris);
            log.logInfo("Attaching Ana");
            ibm.Attach(ana);

            // Fluctuating prices will notify investors
            for (int i=0; i<8; i++)
            {
                if (i%2 == 0)
                {
                    ibm.Price += 1;
                }
                else
                {
                    ibm.Price -= 0.5;
                }
                Thread.Sleep(3000);

                if (ibm.Price > 122)
                {
                    log.logInfo("Detaching Ana");
                    ibm.Detach(ana);
                }
            }

            log.logInfo("Stock monitoring end");

            log.logInfo("Program end");
                        
            Console.ReadKey();
            Logger.closeLog();
        }
    }
}

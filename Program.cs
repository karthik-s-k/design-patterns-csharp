using System;
using System.Threading.Tasks;
using design_patterns_csharp.Strategy;

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


            log.logInfo("Program end");
                        
            Console.ReadKey();
            Logger.closeLog();
        }
    }
}

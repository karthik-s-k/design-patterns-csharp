using System.Collections.Generic;

namespace design_patterns_csharp.Strategy
{
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

    //The classes and objects participating in this pattern are:

    //Strategy  (SortStrategy) 
    //  - declares an interface common to all supported algorithms.Context uses this interface to call the algorithm defined by a ConcreteStrategy
    
    //ConcreteStrategy(QuickSort, ShellSort, MergeSort) 
    //  - implements the algorithm using the Strategy interface
    
    //Context  (SortedList)
    //  - is configured with a ConcreteStrategy object
    //  - maintains a reference to a Strategy object
    //  - may define an interface that lets Strategy access its data.
}

using System;
using System.Collections.Generic;

namespace design_patterns_csharp.Strategy
{
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            //Add merge sort logic

            Console.WriteLine("MergeSorted list ");
        }
    }
}

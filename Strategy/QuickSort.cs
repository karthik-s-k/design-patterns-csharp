using System;
using System.Collections.Generic;

namespace design_patterns_csharp.Strategy
{
    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("QuickSorted list ");         
        }
    }
}

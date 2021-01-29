using System;
using System.Collections.Generic;

namespace design_patterns_csharp.Strategy
{
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            //Add shell sort logic

            Console.WriteLine("ShellSorted list ");
        }

    }
}

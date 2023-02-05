using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Constructors
{
    static class Counter
    {
        public static int _humanCount { get; set; } = 3;
        public static void countHumans()
        {
            Console.Write($"There are {_humanCount} humans");
        }
    }
}

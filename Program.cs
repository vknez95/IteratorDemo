using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    static class Program
    {
        static IEnumerable<int> Populate()
        {
            int current = 0;
            while (true)
                yield return ++current;
        }
        static void Main()
        {
            int n = 100000000;
            long sum = Populate().TakeWhile(x => x <= n).Sum(x => (long)x);

            long expectedSum = (long)n * ((long)n + 1) / 2;
            Console.WriteLine("Sum {{1.. {0:#,##0} = {1:#,##0}}} = {1:#,##0}; expected {2:#,##0}", n, sum, expectedSum);

            Console.ReadLine();
        }
    }
}

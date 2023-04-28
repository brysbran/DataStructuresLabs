using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchesAndSorts
{
    class Searches
    {
        public void SequentialSearch(int[] arrayToSearch, int numberToFind)
        {
            int comparisons = 0;
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                comparisons += 1;
                if (arrayToSearch[i] == numberToFind)
                {
                    Console.WriteLine("Found " + numberToFind + " at index " + i);
                    Console.WriteLine("\nComparisons in the Sequential Search: " + comparisons);
                    return;
                }
            }
            Console.WriteLine("Did not find " + numberToFind);
        }
    }
}

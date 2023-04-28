using System;
using System.Collections.Generic;

namespace Bryson
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>{34, 44, 56};
            List<int> b = new List<int>{35, 44, 53};

            Console.WriteLine(compareTriplets(a, b));
        }

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
        List<int> scores = new List<int>();
        int alice = 0;
        int bob = 0;
        for(int i = 0; i < a.Count; i++)
        {
               if(a[i] < b[i]) 
               {
                bob += 1;
               }
               else if (a[i] > b[i])
               {
                alice += 1;
               }
        }
        scores.Insert(0, alice);
        scores.Insert(1, bob);
        return scores;
    }
    }
}
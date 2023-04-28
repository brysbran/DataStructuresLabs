using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
#5 - Number of Comparisons: 984015
    Number of Swaps: 249105
#7 - One comparison required.
#8 - 1000
#9 - It is very inefficient.
#13 - 501 swaps and 1000 comparisons, this is much more effective than bubble sort because it requires much less swaps and comparisons.
*/

namespace SearchesAndSorts
{
    class Sorts
    {
        public int[] bubbleSort(int[] arrayToSort)
        {
            int comparisons = 0;
            int swaps = 0;
            bool done = false;
            while (!done)
            {
                done = true;
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    comparisons += 1;
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        swap(arrayToSort, i, i + 1);
                        done = false;
                        swaps += 1;
                    }
                }
            }
            Console.WriteLine("Number of Comparisons: " + comparisons + "\nNumber of Swaps: " + swaps);
            return arrayToSort;
        }



        public void swap(int[] arrayToSwap, int indexOne, int indexTwo)
        {
            int temp = arrayToSwap[indexOne];
            arrayToSwap[indexOne] = arrayToSwap[indexTwo];
            arrayToSwap[indexTwo] = temp;
        }

        public static int[] MergeSort(int[] a)
        {
            if (a.Length <= 1) return a;
           
                int inputLength = a.Length;

                //sets the middle index to the total length divided by 2
                int midIndex = a.Length / 2;

                //left side set to the middle index size
                int[] leftArray = new int[midIndex];
                //right side set to the total length minus the middle length
                int[] rightArray = new int[inputLength - midIndex];

                //looping from zero to middle of the array to populate left array
                for (int i = 0; i < midIndex; i++)
                {
                    leftArray[i] = a[i];
                }
                //looping from the middle to the end of the array to populate right array
                for (int i = midIndex; i < inputLength; i++)
                {
                    rightArray[i - midIndex] = a[i];
                }

                //recursively called the method to populate the two sides
                MergeSort(leftArray);
                MergeSort(rightArray);
                //this calls the merge method to put the two halves together
                 return Merge(a, leftArray, rightArray);
          
        }

        private static int[] Merge(int[] a, int[] leftHalf, int[] rightHalf)
        {
           int leftSize = leftHalf.Length;
           int rightSize = rightHalf.Length;

            int i = 0, j = 0, k = 0, comparisons = 0, swaps = 0;
            
                //loops until no more elements in left or right array
                while (i < leftSize && j < rightSize)
                {
                comparisons++;
                if (leftHalf[i] <= rightHalf[j])
                    {
                        //sets the element at iteration k to the elements at i in the left half if
                        //it is smaller than the right half
                        a[k] = leftHalf[i];
                        i++;

                    }
                    else
                    {
                        //if the right half is smaller, set element at iteration k equal to the 
                        //element at index j of the right half
                        a[k] = rightHalf[j];
                        j++;
                        swaps++;
                    }
                    k++;//iterate K
                }
                //these account for leftover elements after the above while loop.
                while (i < leftSize)
                {
                    a[k] = leftHalf[i];
                    i++;
                    k++;
                    swaps++;
                    comparisons++;
                    
                }
                while (j < rightSize)
                {
                   a[k] = rightHalf[j];
                    j++;
                    k++;
                    swaps++;
                    comparisons++;
                }
            Console.WriteLine("Swaps: " + swaps + "\nComparisons: " + comparisons);
            return a;
            
        }
    }
}


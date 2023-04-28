using System;

namespace SearchesAndSorts
{
    class Program : Sorts
    {
        static void Main(string[] args)
        {
            try{
            TextFileReader reader = new TextFileReader();
            int[] numberArray = reader.ReadFile("numbers.txt");
            //printArray(numberArray);
            Sorts sorts = new Sorts();
            //sorts.bubbleSort(numberArray);
            //printArray(numberArray);
            //sorts.selectionSort(numberArray);
       
            //Searches searches = new Searches();
            //searches.SequentialSearch(numberArray, 897);
            //searches.binarySearch(numberArray, 9992);
            //Console.WriteLine("\n\nArray length: " + numberArray.Length);
            MergeSort(numberArray);
            printArray(numberArray);
            }
            catch(IOException ex)
            {
                Console.WriteLine("IO Exception Found.");
            }
            
        }

        public static void printArray(int[] numberArray)
        {
            foreach(int i in numberArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}

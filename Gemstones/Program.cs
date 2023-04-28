using System.Text;
using System;

class Program
{

    /*
     * Complete the 'gemstones' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING_ARRAY arr as parameter.
     */

    public static int gemstones(List<string> arr)
    {
        int counter = 0;
        String firstGem = arr[0];
        List<String> gems = new List<string>();
        int sampleLength = 1;
        while (sampleLength <= firstGem.Length)
        {
            int sampleOffset = 0;
            while (sampleOffset <= firstGem.Length - sampleLength)
            {
                String sample = firstGem.Substring(sampleOffset, sampleLength);
                if (!gems.Contains(sample))
                    gems.Add(sample);
                sampleOffset++;
            }
            sampleLength++;
        }
        foreach (string gem in gems)
        {
            if (hasGem(gem, arr))
                counter++;
        }
        return counter;
    }

    static bool hasGem(string gem, List<string> arr)
    {
        for (int index = 1; index < arr.Count; index++)
        {
            if (arr[index].IndexOf(gem) == -1)
                return false;
        }
        return true;
    }

    static void Main(String[] args)
    {
        List<string> arr = new List<string> { "bsdfj", "asdlkjfdjsa", "bnafvfnsd", "oafhdlasd" };
        Console.WriteLine(gemstones(arr));
    }

}
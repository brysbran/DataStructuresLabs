using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchesAndSorts
{
    class TextFileReader
    {
        public int[] ReadFile(String path)
        {
            int[] numbers;
            List<int> tempList = new List<int>();
            StreamReader reader = new StreamReader(File.OpenRead(path));
            while(!reader.EndOfStream)
            {
                tempList.Add(int.Parse(reader.ReadLine()));   
            }
            numbers = tempList.ToArray();
            return numbers;
        }
        

    }
}

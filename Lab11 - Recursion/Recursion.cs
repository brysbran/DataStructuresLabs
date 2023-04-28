namespace Lab11
{
    public class Recursion
    {

        public int SuperDigit(int input)
        {
            char[] num = input.ToString().ToCharArray();
            //if the length of array is 1, return the first item in the array
            if(num.Length == 1) return int.Parse(num[0].ToString());
            //if the array is null return 1
            if(int.Parse(num) == null) return 1;

            int temp =0;
           
                //needs to add [1]+[2]+[3]+...
            foreach(char ch in num)
            {
                //adds each number in the array to temp
                temp+=int.Parse(ch.ToString());
            }
            //recursively calls itself until the array has 1 digit
            //which is the "super digit"
            return SuperDigit(temp);               
        }

        static int counter = 0;
        public static void Permutate(string input, int start, int end)
        {
            counter++;
            //once the for loop below has reached the char count, prints string
            if(start == end) 
            {
                Console.WriteLine("Number of swaps: " + counter + "\t" + input);
            }
            else
            {
                //start is 0, end is the length of the string
                for(int i = start; i <= end; i++)
                {
                    input = Swap(input, start, i);
                    Permutate(input, start + 1, end); 
                }
            }
        }

        public static string Swap(string word, int one, int two)
        {
            char temp;
            char[] charArray = word.ToCharArray();
            temp = charArray[one];
            charArray[one] = charArray[two];
            charArray[two] = temp;
            string letters = new string(charArray);
            return letters;
        }


    }
}
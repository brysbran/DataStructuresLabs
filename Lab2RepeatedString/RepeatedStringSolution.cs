namespace Bryson
{
    public class RepeatedStringSolution {

        public static long repeatedString(String s, long n)
        {

        long aCounter = 0;
        //for each character in string s
        foreach(char c in s)
        {
            //if char = a
         if(c == 'a')
         //add one to counter
             aCounter++;
        }
        
        //the counter gets mutiplied by the number of times the string fits into the long n
        aCounter *= n/s.Length;

        //calculates the remainder of n / s.length
        long remainder = n%s.Length;
        
        //loops through i less than the remainder
        for(int i = 0; i < remainder; i++)
        {
            //if the character at index i is a, add to the counter
            if(s[i] == 'a')
                aCounter++;
        }
        return aCounter;
    }
     
    }

    
}


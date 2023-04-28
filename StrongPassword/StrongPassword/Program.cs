namespace Tester
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(minimumNumber(13, "Sugma1!"));


        }
        public static int minimumNumber(int n, string password)
        {
            string numbers = "0123456789";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specChar = "!@#$%^&*()-+";

            int charsToAdd = 0;
            char [] numbersC = numbers.ToCharArray();
            char[] lowerCaseC = lowerCase.ToCharArray();
            char[] upperCaseC = upperCase.ToCharArray();
            char[] specCharC = specChar.ToCharArray();

            if (password.IndexOfAny(numbersC) == -1) charsToAdd++;
            if (password.IndexOfAny(lowerCaseC) == -1) charsToAdd++;
            if (password.IndexOfAny(upperCaseC) == -1) charsToAdd++;
            if (password.IndexOfAny(specCharC) == -1) charsToAdd++;

            if (n < 6 && n + charsToAdd < 6)
            {
                return (6 - n);
            }
            else return charsToAdd;

        }
    }
}
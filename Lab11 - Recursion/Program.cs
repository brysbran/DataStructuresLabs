namespace Lab11
{
    public class Program
    {
        static void Main()
        {
            while(true)
        {
            Console.WriteLine("Please enter an integer: ");
            string input = Console.ReadLine();
            Recursion number = new Recursion();
            Console.WriteLine(number.SuperDigit(int.Parse(input)));
            break;
        }
            while(true)
            {
                Console.WriteLine("Please provide 7 characters: ");
                string input = Console.ReadLine();
                //if(input?.Length == 7)
                //{
                Recursion.Permutate(input, 0, input.Length - 1);
               // break;
                //}
               // else Console.WriteLine("Please try again...");
            }
        
        
        }


    }
}
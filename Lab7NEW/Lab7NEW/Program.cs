namespace Lab7
{
    public class Program
    {

        static void Main()

        {
            Lab7.UserFile.Read();

            Console.WriteLine("\nALL USERS: \n\n");
            Lab7.UserFile.AllUsers();
            Console.WriteLine("=================================");
            Console.WriteLine("\nUSERS WITH A STRONG PASSWORD: \n\n");
            Lab7.UserFile.StrongUsers();
            Console.WriteLine("=================================");
            Console.WriteLine("\nUSERS WITH A RANDOMLY ASSIGNED VALUE GREATER THAN 50: \n\n");
            Lab7.UserFile.SeniorUser();
            Console.WriteLine("=================================");

        }
    }
}
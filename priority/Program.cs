namespace PriorityLab
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("is this running");
                NodeFile.Enqueue();
                NodeFile.Dequeue();
            }
            catch (IOException fnf)
            {
                Console.WriteLine("FILE NOT FOUND!");
            }
        }
    }
}
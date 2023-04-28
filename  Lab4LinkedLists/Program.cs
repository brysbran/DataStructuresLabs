namespace Program{
    internal class Program{
        public static void Main(String[] args) {

            do {
                try {
                    Console.WriteLine("Enter FirstName than lastName or type exit");
                    string input = Console.ReadLine() ?? throw new Exception();
                    
                    if(input == null) continue;
                    else if(input.Contains("exit")) break;
                    else { 
                        try {
                            String[] values = input.Split(" ");
                            StudentClass.StudentClass.Insert(new StudentClass.Student(values[1], values[0]));

                        }catch(Exception) { Console.WriteLine("\nHad issues using that input");}
                    }
                }catch(IOException) 
                {continue;}
            } while(true);

            Console.WriteLine("\n\n----------------------------------Results-------------------------------------\nForwards--");
            StudentClass.StudentClass.Forward();
            Console.WriteLine("\n------------------------------------------------------------------------------\nBackwards--");
            StudentClass.StudentClass.Backwards();
            Console.WriteLine("");
            do{
                try
                {
                Console.WriteLine("\n------------------------------------------------------------------------");
                Console.WriteLine("\n Would you like to delete a student?");
                string input = Console.ReadLine()?? throw new Exception();
                if(input == "yes")
                {
                Console.WriteLine("Enter a student to delete.");
                string remove = Console.ReadLine();
                if(remove == null) continue;
                try
                {
                    String[] values = remove.Split(" ");
                    StudentClass.StudentClass.Delete(new StudentClass.Student(values[1], values[0]));
                }
                catch(Exception)
                {
                    Console.WriteLine("\nHad issues using that input");
                }
                }
                if(input == "no")
                {
                    try
                    {
                        Console.WriteLine("\n\n----------------------------------Results-------------------------------------\nForwards--");
                        StudentClass.StudentClass.Forward();
                        Console.WriteLine("\n------------------------------------------------------------------------------\nBackwards--");
                        StudentClass.StudentClass.Backwards();
                        Console.WriteLine("");
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("\nThere was an error.");
                    }
                }
                }
                catch(IOException)
                {
                    continue;
                }
            }while(true);
            
        }
    }
}
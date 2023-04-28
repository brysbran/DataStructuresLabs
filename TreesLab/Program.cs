namespace TreesLab
{
    public class Program
    { 
        static void Main()
        {
            FileReading.Read();
            Console.WriteLine(BinarySearchTree.Add);

        }
    
    
    
    }


    public class FileReading
    {
        private static User[] users;
        public static void Read()
        {
            using (var reader = new StreamReader(@"MOCK_DATA.csv"))
            {
                users = new User[File.ReadLines(@"MOCK_DATA.csv").Count()];
                while (!reader.EndOfStream)
                {
                    Random rand = new Random();
                    bool strPass = false;
                    string[] fields = reader.ReadLine().Split(',');
                    if (fields[4].Length >= 8)
                    {
                        strPass = true;
                    }
                    User temp = new User(fields[0], fields[1], fields[2], fields[3], fields[4], strPass, rand.Next(100));
                    users.Append(temp);
                }
            }
        }


    }

    public class Node
    {
        public Node? LeftNode, RightNode;
        public User Data;
        public Node(){}
        public class User{
            public ARandomValue randomValue;

            public class ARandomValue{
                private int value;

                public ARandomValue(int value)
                {
                    this.value = value;

                }

                public string ToString(string textFormat)
                {
                    return "" + value;
                }
            }
        }

    }


}
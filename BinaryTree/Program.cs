
namespace Program {
    public class Program {
        public static void Main(string[] args) {
            NodeFile.Populate();
            NodeFile.ToString();
            NodeFile.CreateTree();
            Console.WriteLine("number of total levels: "+BinaryTree.BinaryTree.Count());
            Console.WriteLine("number of nodes in tree: "+BinaryTree.BinaryTree.Nodes());
            BinaryTree.BinaryTree.Search(999);
            BinaryTree.BinaryTree.Test();
        }
    }

    //Node class
    public class User
     {
        public User? left, right;
        public Random rand = new Random();
        public string id, first_name, last_name, email, password;
        public int randomNum;
        public bool strongPassword;

        public User(String[] values) 
        {
            randomNum = rand.Next(1000);
            id=values[0]; first_name=values[1]; last_name=values[2]; email=values[3];
            password=values[4];
        }

        public User(String[] values, int randomValue) 
        {
            id=values[0]; first_name=values[1]; last_name=values[2]; email=values[3];
            password=values[4];
        }

        public string Print() 
        {
            return "id: "+id+"\tfirst name: "+first_name+"\tlast name: "+last_name+"\temail: "+email+"\tpassword: "+password+
            "\tstrong password: "+strongPassword+"\t\tnumber: "+randomNum;
        }
    }


    public class NodeFile
    {
        private static User? head,tail,current;
        private const string file_Path = "MOCK_DATA.csv";

        public static void Populate()
         {
            using(var reader = new StreamReader(@file_Path))
             {
                User newNode = new User(reader.ReadLine().Split(','));
                current = head = newNode;

                while(!reader.EndOfStream) 
                {
                    current.right = new User(reader.ReadLine().Split(','));
                    if(tail != null) current.left = tail;
                    tail = current;
                    current = current.right;
                }
            }
        }

        public static void CreateTree() 
        {
            int lowest; User? root = head;

            if(tail != null) 
            {
                current = head;
                lowest = head.randomNum;
                while(current != null) 
                {
                    if(lowest > current.randomNum) {lowest = current.randomNum; root = current;}
                    current = current.right;
                }
                BinaryTree.BinaryTree.makeRoot(root);

                current = head;
                while(current != null)
                 {
                    BinaryTree.BinaryTree.Add(current);
                    current = current.right;
                }
            }
        }

        public static void ToString()
         {
            if(tail != null) {
                current = head;
                while(current != null)
                 {
                    Console.WriteLine(current.Print());
                    current = current.right;
                }
            }

            //BinaryTreePrinter.BinaryTreePrinter.Print(BinaryTree.BinaryTree.head);
        }
    }

}
using Program;

namespace BinaryTree {
    class BinaryTree {
        public static Tree? head,current,tail;
        public static int CountLevel, totalNodes;

        public static void makeRoot(User root) {
            head = new Tree(root);
        }

        public static void Add(User node)
         {
            current = head; 
            tail = head;
            int levels=0; 

            while(true && current != null) 
            {
                if(current.value > node.randomNum) {levels++; //Goes left
                    if(current.less == null) 
                    {
                        current.less = new Tree(node); 
                        totalNodes++; 
                        current.less.parent = tail;
                        break;
                    } 
                    else 
                    {
                        tail = current; current = current.less;
                    }

                }
                else if(current.value < node.randomNum) {levels++; //Goes right
                    if(current.more == null) 
                    {
                        current.more = new Tree(node);
                        totalNodes++; 
                        current.more.parent = tail; 
                        break;
                    }
                     else 
                    {
                        tail = current; 
                        current = current.more;
                    }

                }
                 else 
                 {
                    Console.WriteLine($"cannot add User[duplicate values]{node.randomNum}"); break;
                 }
            }
            if(levels > CountLevel) CountLevel = levels;
        }

        public static int Count()
        {
            return CountLevel;
        }

        public static int Nodes() 
        {
            return totalNodes;
        }

        public static void Search(int val) 
        {
            current = head; int result = head.value;
            int level = 0;

            while(current !=null) 
            {
                if(val > current.value) 
                {
                    current = current.more; level++;
                } 
                else if(val < current.value) 
                {
                    current = current.less; level++;
                } else 
                {
                    if(val == current.value) {result = current.value; break;}
                    else {Console.WriteLine("Value not found: "+val);}
                }
            }

            Console.WriteLine("found value: "+result+" at level: "+level);
        }
    
        public static void Test() 
        {
            Console.WriteLine(head.value);

            current = head; 
            while(true) 
            {
                if(current.more == null) break;
                current = current.more;
                Console.WriteLine(current.value);
            } 
        }

   
    }


    public class Tree
    {
        public Tree Root { get { return this; } }
        public Tree? parent;
        public Tree? less, more;
        public User obj;
        public int value;

        public Tree(User obj)
        {
            this.obj = obj;
            value = obj.randomNum;
        }
    }
}
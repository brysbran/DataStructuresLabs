

namespace StudentClass {

    internal class StudentClass {
        private static Node? head;
        private static Node? tail;
        private static Node? comparable;
        private static Node? current;

        private static void sort() {
            //Find length by going through Nodes
            int length = 0;
            current = head;
            while(current != null) {length++; current = current.next;}

            //sort by last names using bubblesort
            comparable = tail;
            current = head;
            for(int i=0; i < length; i++) {
                for(int k=0; k < length; k++) {
                    while(current != null && comparable != null && current != null) {
                        if(current.value.lastName.CompareTo(comparable.value.lastName) == 1) {
                            Swap(current, comparable);}
                        if(current.value.lastName.CompareTo(comparable.value.lastName) == -1) {
                            Swap(current, comparable);}
        
                        comparable = current.prev;
                        break;
                    }
                }

                while(current != null) {current = current.next; break;}
            }

        }

        //You cant swap nodes around but can swap the values in the nodes around
        private static void Swap(Node current, Node comparable){
            Student temp = current.value;
            current.value = comparable.value;
            comparable.value = temp;
        }

        public static void Insert(Student obj) {
            Node newNode = new Node(obj);
            if(tail == null) head = newNode;
            else {
                newNode.prev = tail;
                tail.next = newNode;
            }

            tail = newNode;
            sort();
        }

        public static void Delete(Student obj) 
        {
            current = head;
            while (current != null)
            {
                if (current.value.lastName == obj.lastName)
                    {
                        current.prev.next = current.next;
                        current.next.prev = current.prev;
                        current = null;
                        break;
                    }
                current = current.next;
                
            }
            sort();

            
        }

        public static void Forward() {
            if(tail != null) {
                current = head;
                while(current != null) {
                    Console.WriteLine("LastName: "+current.value.lastName+"\t\t\tFirstName: "+current.value.firstName);
                    current = current.next;
                }
            }
        }

        public static void Backwards() {
            if(tail != null) {
                current = tail;
                while(current != null) {
                    Console.WriteLine("LastName: "+current.value.lastName+"\t\t\tFirstName: "+current.value.firstName);
                    current = current.prev;
                }
            }
        }

        
    }

    class Node {
        public Student value;
        public Node? next;
        public Node? prev;

        public Node(Student stud) {
            value = stud;
        }
    }

    class Student {
        public String lastName;
        public String firstName;

        public Student(String lastName, String firstName) {
            this.lastName = lastName;
            this.firstName = firstName;
        }

    }
}
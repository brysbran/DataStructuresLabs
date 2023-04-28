using System;
using System.Collections.Generic;
using System.Collections;

namespace PriorityLab
{
    public class Node
    {
        public User Data;
        public Node? _left; //prev
        public Node? _right; //next


        //contains user object and data.
        public Node(string[] values, int random_value)
        {
            Data = new User(values, random_value);
        }
    }

    public class User
    {
        public ARandomValue randomValue = new ARandomValue();
        public string id, first_name, last_name, email, password;
        public bool strongPassword;

        public User(string[] values, int randomValue)
        {
            id = values[0]; first_name = values[1];
            last_name = values[2]; email = values[3];
            password = values[4]; this.randomValue.value = randomValue;
            if (password.Length >= 8) strongPassword = true;
            else strongPassword = false;
        }

        public string Print()
        {
            return id + " " + first_name + " " + last_name + " " + email + " " + password;
        }

        public class ARandomValue
        {
            public int value;
            public string ToString(string textFormat)
            {
                return "" + value;
            }
        }
    }
    //contains the methods to give the nodes data and to also print that data.
    public class NodeFile
    {
        private static Node? head, tail, current, comparable, prev;
        private static Random rand = new Random();
        private const string file_Path = "MOCK_DATA.csv";

        public static void Swap(Node current, Node comparable)
        {
            int temp = current.Data.randomValue.value;
            current.Data.randomValue.value = comparable.Data.randomValue.value;
            comparable.Data.randomValue.value = temp;
        }


        public static void Enqueue()
        {
            using (var reader = new StreamReader(@file_Path))
            {
                //creates head of linked list
                Node newNode = new Node(reader.ReadLine().Split(','), rand.Next(1000));
                current = head = newNode;
                while (!reader.EndOfStream)
                {
                    //creates next node after head until end of file
                    current._right = new Node(reader.ReadLine().Split(','), rand.Next(1000));

                    //if the tail exists, the oldest node is the new tail
                    if (tail != null) current._left= tail;
                    while(head != null)
                    {
                        if(current.Data.randomValue.value < current._right.Data.randomValue.value)
                        {
                            current._right = current._left;
                        }
                        else current = head;
                    }
                    
                    //sets the current node to the next node in the list so while loop continues.
                    current = current._right;
                    //Sort();
                }

            }
        }

        public static void printUnordered()
        {
            if (tail != null)
            {
            
                current = head;
                while (current != null)
                {
                    Console.WriteLine("LastName: " + current.Data.last_name + "\t\t\tFirstName: " + current.Data.first_name + " \t\tRandomNumber: " + current.Data.randomValue.value);
                    current = current._right;
                }
            }
        }

        public static void Dequeue()
        {
            if (tail != null)
            {

                current = head;
                while (current != null)
                {
                    Console.WriteLine("LastName: " + current.Data.last_name + "\t\t\tFirstName: " + current.Data.first_name + " \t\tRandomNumber: " + current.Data.randomValue.value);
                    current = current._right;
                }
            }
        }

      






    }
}
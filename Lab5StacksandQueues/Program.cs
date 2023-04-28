using System;
using System.Collections.Generic;

namespace Lab5StacksandQueues
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<String> daStack = new Stack<String>();
            Stack<int> intStack = new Stack<int>();

            do
            {
                Console.WriteLine("Would you like to reverse a String?");
                if (Console.ReadLine() == "yes")
                {
                    Console.WriteLine("Enter a string.");
                    String userString = Console.ReadLine();
                    daStack.Push(userString);
                    for (int i = userString.Length - 1; i >= 0; i--)
                    {
                        Console.Write(userString[i]);
                    }
                }
                Console.WriteLine("\n\nConvert an integer to its binary representation?");
                if(Console.ReadLine() == "yes")
                {
                    Console.WriteLine("Provide an integer.");
                    int userInt = int.Parse(Console.ReadLine());
                    intStack.Push(userInt);
                    int remainder;
                    string result = string.Empty;
                    
                    
                    while(userInt > 0)
                    {
                        //mod 2 bc binary is base 2
                        remainder = intStack.Peek() % 2;
                        //divide the user integer
                        intStack.Pop();
                        userInt /= 2;
                        intStack.Push(userInt);
                        //the binary result will be the remainder plus the result until userInt !> 0
                        result = remainder.ToString() + result;
                        daStack.Push(result); 
                    }
                    Console.WriteLine("Binary: " + daStack.Pop());

                }
                Console.WriteLine("\nWould you like provide a string with parenthesis");
                if(Console.ReadLine() == "yes")
                {

                    Console.WriteLine("Provide a string with parenthesis...");
                    string userString = Console.ReadLine();
                    daStack.Push(userString);

                       
                       char[] temp = daStack.Peek().ToCharArray();
                       for(int i = 0; i < temp.Length; i++)
                        {
                            if(temp[i] == '(')
                            {
                            String pTemp = daStack.Pop();
                            pTemp += ")";
                            daStack.Push(pTemp);
                            }
                            if(temp[i] == ')')
                             {
                                String hold = daStack.Pop();
                                hold += "(";
                                daStack.Push(hold);
                             }
                        }
                       Console.WriteLine(daStack.Pop());
                }
                Console.WriteLine("Would you like to use the queue methods?");
                 if(Console.ReadLine() == "yes")
                {
                    IntegerQueue.Enqueue(8);
                    IntegerQueue.Enqueue(5);
                    IntegerQueue.Enqueue(6);
                    IntegerQueue.Dequeue();
                    IntegerQueue.Dequeue();
                    IntegerQueue.Enqueue(14);
                    IntegerQueue.Enqueue(27);
                    IntegerQueue.Dequeue();
                    IntegerQueue.Dequeue();
                    IntegerQueue.Dequeue();

                }
            }while(true);
        }




    }


}

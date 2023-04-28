using System;
using System.Threading;

namespace Bryson
{
    public class Program
    {
       static void Main(String[] args)
        {
            ThreadIterators.ThreadStarter();

            Console.WriteLine("\n\nALL DONE!");



        }
        

    }

    public class ThreadIterators
    {

        public static void ThreadOne()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Thread One Iterations: " + i);
                Thread.Sleep(300);
            }

        }
        public static void ThreadTwo()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Thread Two Iterations: " + i);
                Thread.Sleep(300);
            }

        }
        public static void ThreadThree()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Thread Three Iterations: " + i);
                Thread.Sleep(300);
            }

        }
        public static void ThreadFour()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Thread Four Iterations: " + i);
                Thread.Sleep(300);
            }

        }
        public static void ThreadFive()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Thread Five Iterations: " + i);
                Thread.Sleep(300);
            }

        }

        public static void ThreadStarter()
        {
            Thread t1 = new Thread(new ThreadStart(ThreadOne));
            Thread t2 = new Thread(new ThreadStart(ThreadTwo));
            Thread t3 = new Thread(new ThreadStart(ThreadThree));
            Thread t4 = new Thread(new ThreadStart(ThreadFour));
            Thread t5 = new Thread(new ThreadStart(ThreadFive));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();


        }




    }

}
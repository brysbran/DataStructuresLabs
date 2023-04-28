using System;
using System.Collections.Generic;
using System.IO;

namespace Lab7
{
    public class UserFile
    {
        private static List<User> users = new List<User>();


        public static void Read()
        {
            using (var reader = new StreamReader(@"C:\Users\brandonbc\source\repos\Lab7NEW\Lab7NEW\MOCK_DATA.csv"))
            {
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
                    users.Add(temp);
                }
            }
        }

        public static void AllUsers()
        {

            foreach (User temp in users)
            {
                Console.WriteLine(temp.Display());
            }
        }

        public static void StrongUsers()
        {

            foreach (User temp in users)
            {
                if (temp.strongPassword == true)
                {
                    Console.WriteLine(temp.Display());
                }
            }
        }

        public static void SeniorUser()
        {
            foreach (User temp in users)
            {
                if (temp.randomValue > 50)
                {
                    Console.WriteLine(temp.Display());
                }
            }
        }

    }
}

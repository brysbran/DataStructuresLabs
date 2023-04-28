using System;
using System.Collections;
using System.IO;

namespace TreesLab
{
    public class User
    {
        public string id;
        public string first_name;
        public string last_name;
        public string email;
        public string password;
        public bool strongPassword;
        public int randomValue = 0;
        public User val;
        public static User root {get; set;}
        public static User leftNext { get; set; }
        public static User rightNext { get; set; }

        public User()
        {
        
        }


        public User(string id, string first_name, string last_name, string email, string password, bool strongPassword, int randomValue)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.password = password;
            this.strongPassword = strongPassword;
            this.randomValue = randomValue;

        }

        public string Display()
        {
            return id + "|" + first_name + "|" + last_name + "|" + email + "|" + password + "|" + strongPassword + "|" + randomValue;
        }

        public static void Add(User[] users)
        {
            User root = new User();
            this.root = root;
            /*Node root = new Node();
            users[0] = root.Root;
            for(int i = 0; i < users.Length; i++)
            {
                Node temp = new Node();
                if(users[i].randomValue < users[0].randomValue) users[i] = temp.LeftNext;
                if(users[i].randomValue > users[0].randomValue) users[i] = temp.RightNext;
*/
            
            if(root == null) users[0] = root;
            else
            {
                for(int i = 0;i<users.Length;i++)
                {
                    if(users[i].randomValue < root.randomValue) Add(users[i]) = User.root.LeftNext;
                    if(users[i].randomValue > root.randomValue) Add(users[i]) = User.RightNext;
                }
            }

            }



    }
    }


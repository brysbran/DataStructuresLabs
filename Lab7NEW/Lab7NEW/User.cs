using System;
using System.Collections;
using System.IO;

namespace Lab7
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
           return id + "|" +  first_name + "|" + last_name + "|" + email + "|" + password + "|" + strongPassword + "|" + randomValue;
        }



    }
}

using System;
using System.Text.RegularExpressions;

namespace RegexLab
{


    public class Program
    {
        static void Main()
        {
            
           //part one
            string first_name = "";
            string last_name = "";
            string address = "";
            string state = "";
            string zipcode = "";
            string phone = "";
            string email = "";
            string type = "";
            string date = "";
            while(true)
            {
                Console.WriteLine("Please provide your first name: ");
                first_name = Console.ReadLine();
                //any one capital char, followed by 0 to 11 lowercase chars
                Regex reggy = new Regex(@"[A-Z][a-z]{0,11}");
                if (reggy.IsMatch(first_name) || first_name.Equals(""))
                {
                break;
                } 
                else Console.WriteLine("Please Try Again...");
            }
            
            while(true)
            {
                Console.WriteLine("Please Provide your last name: ");
                last_name = Console.ReadLine();
                //any one capital char, followed by 0 to 11 lowercase chars
                Regex lastReg = new Regex(@"[A-Z][a-z]{0,15}");
                if (lastReg.IsMatch(last_name) || last_name.Equals("")) {break;}
                else Console.WriteLine("Please Try Again...");
            }
           
            while(true)
            {
                Console.WriteLine("Provide a street address: ");
                address = Console.ReadLine();
                //any 3 numbers followed by any one capital char and 0 to 15 lowercase
                Regex addressReg = new Regex(@"(^\d{3})+\s([A-Z][a-z]{0,15})");
                if (addressReg.IsMatch(address) || address.Equals("")) {  break;}
                else Console.WriteLine("Please Try Again...");
            }
            
            while (true)
            {
                Console.WriteLine("Provide the state you reside in by two CAPITAL letters: ");
                state = Console.ReadLine();
                Regex stateReg = new Regex(@"[A-Z]{2}");
                if (stateReg.IsMatch(state) || state.Equals("")){break;}
                else Console.WriteLine("Please Try Again...");
            }
            
            while(true)
            {
                Console.WriteLine("Please provide the zip-code of the address in which you reside: ");
                zipcode = Console.ReadLine();
                Regex zipReg = new Regex(@"([0-9]{5})+\-?([0-9]{4})");
                if (zipReg.IsMatch(zipcode) || zipcode.Equals("")) {break;}
                else Console.WriteLine("Please try again...");
            }
            while(true)
            {
                Console.WriteLine("Please enter your phone number: ");
                phone = Console.ReadLine();
                Regex phoneReg = new Regex(@"\(?([0-9]{3})+\)?\-?([0-9]{3})\-?([0-9]{4})");
                if(phoneReg.IsMatch(phone) || phone.Equals("")) {break;}
                else Console.WriteLine("Please try again...");
            }
            while(true)
            {
                Console.WriteLine("Please provide your email address: ");
                email = Console.ReadLine();
                Regex emailReg = new Regex(@"([a-z]{0,15})([0-9]{0,5})?\@([a-z]{0,15})\.(org|net|com)");
                if(emailReg.IsMatch(email) || email.Equals("")) {break;}
                else Console.WriteLine("Please try again...");
            }
            while(true)
            {
                Console.WriteLine("Please provide your credit card number: (totally not sus...)");
                string credit = Console.ReadLine();
                type = "";
                Regex masterCard = new Regex(@"(5[1-5])([0-9]{2})\-?([0-9]{4})\-?([0-9]{4})\-?([0-9]{4})");
                Regex visa = new Regex(@"(4[0-9]{13,16})");
                Regex amex = new Regex(@"(3[4|7])([0-9]{13})");
                Regex dinersClub = new Regex(@"(30[0-5]|3[6|8])([0-9]{11,12})");
                Regex discover = new Regex(@"(6011)([0-9]{12})");
                Regex jcb = new Regex(@"(3|1800|2131)([0-9]{15,16})");

                if(masterCard.IsMatch(credit)) {type = "MasterCard";break;}
                else if(visa.IsMatch(credit)) {type = "Visa"; break;}
                else if(amex.IsMatch(credit)) {type = "American Express"; break;}
                else if(dinersClub.IsMatch(credit)) {type = "Diner's Club"; break;}
                else if(discover.IsMatch(credit)) {type = "Discover";  break;}
                else if(jcb.IsMatch(credit)) {type = "JCB";  break;}
                else Console.WriteLine("Please try again...");
            }
            while(true)
            {
                Console.WriteLine("Please provide your credit card's expiration date: ");
                date = Console.ReadLine();
                Regex dateReg = new Regex(@"([0-9]{2})\/([0-9]{2})");
                if(dateReg.IsMatch(date)) {break;}
                else Console.WriteLine("Please try again...");
            }


            Console.WriteLine("\n\nFirst Name: " + first_name + "\nLast Name: " + last_name + "\nStreet Address: " + address + "\nState: " + state + "\nZip: " + zipcode + "\nPhone Number: " + phone + "\nEmail Address: " + email + "\nCard issuer: " + type);

        }
    }

}
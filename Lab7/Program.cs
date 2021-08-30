using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {

           IsValidName();
           IsValidEmail();
           IsValidPhone();
          IsValidDate();


        }


        public static void IsValidName()
        {

            Regex nameRegex = new Regex(@"(\b[A-Z]\D)+\D[^0-9][a-z]{0,30}\b");

            Console.Write("Please enter a valid Name: ");
            string validName = Console.ReadLine();

            if (nameRegex.IsMatch(validName))
            {
                Console.WriteLine("Name is valid");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid!");
            }

        }



        public static bool IsValidEmail()
        {

            Regex emailRegex = new Regex(@"^([A-Za-z0-9]{5,30})@([A-Za-z0-9]{5,10}).([A-Za-z0-9]{2,3})$");

            Console.Write("Please enter a valid email: ");
            string validEmail = Console.ReadLine();

            if (emailRegex.IsMatch(validEmail))
            {
                Console.WriteLine("Email is valid!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, email is not valid!");
                return false;
            }
        }

        public static bool IsValidPhone()
        {

            Regex emailRegex = new Regex(@"\b(\d\d\d)-(\d\d\d)-(\d\d\d\d)\b");

            Console.Write("Please enter a valid phone number: ");
            string validPhone = Console.ReadLine();

            if (emailRegex.IsMatch(validPhone))
            {
                Console.WriteLine("Phone is valid!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, phone is not valid!");
                return false;
            }
        }




        public static bool IsValidDate()
        {

            Regex emailRegex = new Regex(@"\b(\w{5,30})\b@(\w{5,10}).(\w{2,3})");

            Console.Write("Please enter a valid phone number: ");
            string validDate = Console.ReadLine();

            if (emailRegex.IsMatch(validDate))
            {
                Console.WriteLine("Date is valid!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, date is not valid!");
                return false;
            }
        }

    }
}




//var testNameDictionary = new Dictionary<string, bool>();
//testNameDictionary.Add("Stephanie@gmail.com", true);
//    testNameDictionary.Add("Ryan1@a.com", false);
//    testNameDictionary.Add("Thisisanamethatshouldhaveoverthritycharacters@gmail.com", false);
//    testNameDictionary.Add("paul@a.com", false);
//    testNameDictionary.Add("Not!name@gmail.com", false);

//    Regex nameRegex = new Regex(@"\b([A-Za-z0-9]{5,30})@([A-Za-z0-9]{5,10}).([A-Za-z0-9]{2,3})\b");

//    foreach (KeyValuePair<string, bool> pair in testNameDictionary)
//    {
//        var result = nameRegex.IsMatch(pair.Key);
//var doesNameTestPass = result == pair.Value ? "SUCCESS" : "FAIL";

//Console.WriteLine($"Name Test: {pair.Key} | {doesNameTestPass}");

//^[^!~@#$^&*()-_+=[\]{}|,.?:]*$

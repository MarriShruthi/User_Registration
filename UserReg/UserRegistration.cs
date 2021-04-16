using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserReg
{
    class UserRegistration
    {
        public static void FName()
        {
            string regex = "[A-Z]{1}[a-z]{3,10}$";
            Console.WriteLine("Enter your First Name :");
            string fName = Console.ReadLine();
            Regex rg = new Regex(regex);
          //  Match result = Regex.Match(fName, regex);
            bool result1 = rg.IsMatch(fName);
            if (result1 == true)
            {
                Console.WriteLine("valid Input");
                Console.WriteLine("your first name : " + fName);
            }
            else
            {
                Console.WriteLine("invalid input ");
            }
        }
    }
}


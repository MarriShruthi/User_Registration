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
            Console.WriteLine("Enter your Last Name (First letter must be capital letter) :");
            string lName = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(lName);
            if (result == true)
            {
                Console.WriteLine("valid Input");
                Console.WriteLine("your last name : " + lName);
            }
            else
            {
                Console.WriteLine("invalid input ");
            }
        }
    }
}


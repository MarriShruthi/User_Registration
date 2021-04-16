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
            string regex = "[91]{2} [0-9]{10}";
            Console.WriteLine("Enter your Phone Number (with country code 91)  :");
            string PhNo = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(PhNo);
            if (result == true)
            {
                Console.WriteLine("valid Input");
                Console.WriteLine("your Phone Number is : " + PhNo);
            }
            else
            {
                Console.WriteLine("invalid input ");
            }
        }
    }
}


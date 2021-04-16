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
            string regex = "[a-zA-Z0-9_.]+@[a-zA-Z.]+$";
            Console.WriteLine("Enter your Mail Id :");
            string Mail = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(Mail);
            if (result == true)
            {
                Console.WriteLine("valid Input");
                Console.WriteLine("your Mail Id is : " + Mail);
            }
            else
            {
                Console.WriteLine("invalid input ");
            }
        }
    }
}


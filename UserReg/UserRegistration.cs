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
            string regex = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#&$])(?=\\S+$).{4,10}$";
            Console.WriteLine("Enter your Password :");
            string password = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(password);
            if (result == true)
            {
                Console.WriteLine("valid Input");
                Console.WriteLine("your Phone Number is : " + password);
            }
            else
            {
                Console.WriteLine("invalid input ");
            }
        }
    }
}


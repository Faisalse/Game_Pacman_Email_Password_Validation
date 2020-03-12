using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace GhostUpdateVersion
{
    class PasswordEmailHandling
    {
        public PasswordEmailHandling()
        {
            Console.WriteLine("Press 0: Email validation");
            Console.WriteLine("Press 1: Passwrod validation");
            int value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case 0:
                    EmailValidation();
                    break;
                case 1:
                    PasswordValidation();
                    break;
                default:
                    Console.WriteLine("You are not entered correct value");
                    break;

            }
        }
        public void EmailValidation()
        {
            //Regex for email validation
            Regex r = new Regex(@"^([a-zA-Z0-9]{8,15}@[a-z]{5,10}\.com$)");
            Console.WriteLine("Enter your email");
            string name = Console.ReadLine();
            Match match = r.Match(name);
            //Console.WriteLine("Enter email here");
            //string email = Console.ReadLine();
            //Console.WriteLine(match.Success);
            Console.WriteLine(match.Success);
            if (match.Success)
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                EmailValidation();
            }
        }

        public void PasswordValidation()
        {
            Console.WriteLine("Enter the password:");
            string name = Console.ReadLine();
            // Regex for Password validation
            Regex regex = new Regex(@"^(((\W*(1|3|5|7|9)\W*[a-z]{1}\W*[A-Z]{1}\W*)+)|(\W*(1|3|5|7|9)\W*[A-Z]{1}\W*[a-z]{1}\W*)+|(\W*[A-Z)]{1}\W*(1|3|5|7|Z)\W*[a-z]{1}\W*)+|(\W*[A-Z)]{1}\W*[a-z]{1}\W*(1|3|5|7|9)\W*)+|(\W*[a-z)]{1}\W*[A-Z]{1}\W*(1|3|5|7|9)\W*)+|(\W*[a-z)]{1}\W*(1|3|5|7|9)\W*[A-Z]{1}\W*)+)$");
            Match match = regex.Match(name);

            if (match.Success)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Enter the correct password");
            }
        }

    }
}

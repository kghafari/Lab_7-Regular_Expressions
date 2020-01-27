using System;
using System.Text.RegularExpressions;

namespace Lab_7___Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimmie name!");
            string nameInput = Console.ReadLine();

            //name 
            if (AskIfName(nameInput))
            {
                Console.WriteLine("Probably a name(main)");
            }
            else
            {
                Console.WriteLine("Probably not a name");
            }

            //email
            Console.WriteLine("Gimmie email!");
            string emailInput = Console.ReadLine();
            {
                if (AskIfValidEmail(emailInput))
                {
                    Console.WriteLine("Probably an email!");
                }
                else
                {
                    Console.WriteLine("Probably NOT an email.");
                }
            }

            //phone #
            Console.WriteLine("Enter phone number: (Format: xxx-xxx-xxxx)");
            string phoneNoInput = Console.ReadLine();
            if(AskIfValidPhoneNumber(phoneNoInput))
            {
                Console.WriteLine("Probably a valid phone #.");
            }
            else
            {
                Console.WriteLine("Probably not a valid phone #.");
            }

            Console.WriteLine("Enter a date: (mm/dd/yyyy).");
            string dateInput = Console.ReadLine();
            if(AskIfValidDate(dateInput))
            {
                Console.WriteLine("Probably a valid date.");
            }
            else
            {
                Console.WriteLine("Probably NOT a valid date.");
            }
        }

        public static bool AskIfName(string name)
        {
            //Starts at ... start of word (^), first position must be a capital letter ([A-Z]), second thru (up to) 30th position must be lowercase ([a-z]{1,30}), end of word ($)
            string namePattern = "^[A-Z][a-z]{1,30}$";
            //string nameRegEx = "^([A-Z])([a-z]{1,30})$";
            if (Regex.IsMatch(name, namePattern))
            {
                //Console.WriteLine("Probably a name!");
                return true;
            }
            else;
            {
                //Console.WriteLine("Probably not a name");
                return false;
            }
        }


        public static bool AskIfValidEmail(string maybeEmail)
        {
            string emailPattern = "^([A-Za-z0-9]+)@([A-Za-z0-9]{1,10}).([A-Za-z0-9]{1,3})$";

            // email address before @ => ([A-Za-z0-9]+)
            // @ => @
            // website => ([A-Za-z0-9]{1,10})
            // . => .
            // domain => ([A-Za-z0-9]{1,3})

            if (Regex.IsMatch(maybeEmail, emailPattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AskIfValidPhoneNumber(string maybePhoneNumber)
        {
            string phoneNoPattern = @"^([0-9]{3}(.|-))([0-9]{3}(.|-))([0-9]{4})$";

            if(Regex.IsMatch(maybePhoneNumber, phoneNoPattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AskIfValidDate(string maybeDate)
        {
            
            //date pattern is dd/mm/yyyy
            string datePattern = @"^([0-12]{2})/([0-31]{2})/([0-9]{4})$";

            if (Regex.IsMatch(maybeDate, datePattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


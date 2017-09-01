using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyConsole
{
    class EmployeeUI : User
    {
        CreateAccount newAccount;
        public override void SetUser()
        {
            string FirstName = SetFirstName();
            string LastName = SetLastName();
            string UserName = SetUserName();
            string Password = SetPassword();
            string PreferedAnimalPersonality = "";
            int houseActivityLevelInt = 0;
            newAccount = new CreateEmployee();
            newAccount.StartCreate(FirstName, LastName, UserName, Password, PreferedAnimalPersonality, houseActivityLevelInt);
        }
        static string SetFirstName()
        {
            Console.WriteLine("Enter Your first name.");
            string tempFirstName = Console.ReadLine();
            return tempFirstName;
        }

        static string SetLastName()
        {
            Console.WriteLine("Enter Your last name.");
            string tempLastName = Console.ReadLine();
            return tempLastName;
        }

        static string SetUserName()
        {
            Console.WriteLine("What would you like your username to be?");
            string tempUserName = Console.ReadLine();
            //try catch this when adding to database to check if username is taken.
            return tempUserName;
        }

        static string SetPassword()
        {
            Console.WriteLine("Please enter your password");
            string tempPassword = Console.ReadLine();
            Console.WriteLine("Please re-enter the password to varify its correct");
            string checkTempPassword = Console.ReadLine();
            if (tempPassword != checkTempPassword)
            {
                Console.WriteLine("Those did not match please try again.");
                Console.ReadLine();
                SetPassword();
                return checkTempPassword;
            }
            else
            {
                return checkTempPassword;
            }
        }
    }
}

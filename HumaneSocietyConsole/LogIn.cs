using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyConsole
{
    class LogIn
    {
        User user;
        public void Start()
        {
            Console.WriteLine("1 = adoptee login\n2 = employee login\n3 = new account.");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    
                    break;
                case "2":

                    break;
                case "3":
                    Console.WriteLine("Would you like to create a user account or an employee account.\n1 = user\n2 = employee");
                    string chooseType = Console.ReadLine();
                    ChooseAccountType(chooseType);
                    break;
                default:
                    Console.WriteLine("Sorry try again.");
                    Console.ReadLine();
                    Start();
                    break;
            }
        }
        void ChooseAccountType(string input)
        {
            switch (input)
            {
                case "1":
                    user = new AdopteeUI();
                    user.SetUser();
                    break;
                case "2":
                    user = new EmployeeUI();
                    user.SetUser();
                    break;
                default:
                    Console.WriteLine("Sorry that didn't work please try again.");
                    Console.ReadLine();
                    Start();
                    break;
            }
        }
    }
}

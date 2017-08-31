using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyConsole
{
    static class LogIn
    {
        static public void Start()
        {
            Console.WriteLine("1 = adoptee log in\n2 = employee log in\n3 = new account.");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":
                    CreateAccount.SetUser();
                    break;
                default:
                    Console.WriteLine("Sorry try again.");
                    Console.ReadLine();
                    Start();
                    break;
            }
        }
    }
}

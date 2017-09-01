using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyConsole
{
    class LogIn
    {
        public void Start()
        {
            Console.WriteLine("1 = adoptee login\n2 = employee login\n3 = new account.");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    AdopteeLogIn();
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
                    CreateAccount.SetCreateAdoptee();
                    break;
                case "2":
                    CheckAuthorize();
                    break;
                default:
                    Console.WriteLine("Sorry that didn't work please try again.");
                    Console.ReadLine();
                    Start();
                    break;
            }
        }
        void CheckAuthorize()
        {
            string athorizePassword = "password";
            Console.WriteLine("Please enter the password in order to verify you are athorized to make an employee acount");
            string userInput = Console.ReadLine();
            if(userInput != athorizePassword)
            {
                Console.WriteLine("That was incorrect.");
                Console.ReadLine();
                Start();
            }
            else
            {
                CreateAccount.SetCreateEmployee();
            }
        }
        void AdopteeLogIn()
        {
            adopter ADOPTER = new adopter();
            string tempUserName;
            string tempPassword;
            Console.WriteLine("Please enter your username");
            tempUserName = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            tempPassword = Console.ReadLine();
            CheckUserName(tempUserName, tempPassword, ADOPTER);

        }

        ///////MAKE A WHERE STATEMENT THAT CHECKS A USERNAME AND THEN WHERE THAT USERNAME EXISTS CHECK THE PASSWORD
        ///////USING CLIENT??
        //void CheckUserName(string tempUserName, string tempPassword, adopter ADOPTER)
        //{        
        //    foreach (var item in ADOPTER)
        //    {
        //        string itemString = item.ToString();
        //        if (itemString == tempUserName)
        //        {
                    
        //            CheckPassword(tempPassword, itemString);
        //        }
        //    }
        //    Console.WriteLine("We couldnt find a matching user name.");
        //    Console.ReadLine();
        //    AdopteeLogIn();
        //}
        //void CheckPassword(string tempPassword, string userName)
        //{
        //    foreach (var item in ADOPTER.Pass)
        //    {
        //        string itemString = item.ToString();
        //        if (itemString == tempPassword)
        //        {
        //            AdopteeUI.MainMenu();
        //        }
        //    }
        //    Console.WriteLine("Sorry Wrong Password.");
        //    Console.ReadLine();
        //    Console.WriteLine("Please enter your password");
        //    string newTempPassword = Console.ReadLine();
        //    CheckPassword(newTempPassword, ADOPTER);
        //}
    }
}
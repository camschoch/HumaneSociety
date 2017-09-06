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
                    EmployeeLogIn();
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
            string tempUserName;
            string tempPassword;
            Console.WriteLine("Please enter your username");
            tempUserName = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            tempPassword = Console.ReadLine();
            CheckUserNameAdoptee(tempUserName, tempPassword);

        }
        void EmployeeLogIn()
        {
            string tempUserName;
            string tempPassword;
            Console.WriteLine("Please enter your username");
            tempUserName = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            tempPassword = Console.ReadLine();
            CheckUserNameEmployee(tempUserName, tempPassword);
        }
        void CheckUserNameAdoptee(string tempUserName, string tempPassword)
        {
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            foreach (var item in context.adopters.Where((a) => a.Username == tempUserName))
            {             
                    CheckPasswordAdoptee(tempPassword, item);                
            }
            Console.WriteLine("We couldnt find a matching user name.");
            Console.ReadLine();
            AdopteeLogIn();
        }
        void CheckPasswordAdoptee(string tempPassword, adopter item)
        {
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            string password = item.Pass;
            
                if (password == tempPassword)
                {
                AdopteeUI.MainMenu(item);
                }
            Console.WriteLine("Sorry Wrong Password.");
            Console.ReadLine();
            AdopteeLogIn();
        }
        void CheckUserNameEmployee(string tempUserName, string tempPassword)
        {
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            foreach (var item in context.employees.Where((a) => a.Username == tempUserName))
            {                
                CheckPasswordEmployee(tempPassword, item);                
            }
            Console.WriteLine("We couldnt find a matching user name.");
            Console.ReadLine();
            EmployeeLogIn();
        }
        void CheckPasswordEmployee(string tempPassword, employee item)
        {
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            if (item.Pass == tempPassword)
            {
                EmployeeUI.MainMenu(item);
            }
            Console.WriteLine("Sorry Wrong Password.");
            Console.ReadLine();
            EmployeeLogIn();
        }

    }
}
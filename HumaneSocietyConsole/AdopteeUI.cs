using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyConsole
{
    class AdopteeUI : User
    {
        CreateAccount newAccount;
        public override void SetUser()
        {
            string FirstName = SetFirstName();
            string LastName = SetLastName();
            string UserName = SetUserName();
            string Password = SetPassword();
            string PreferedAnimalPersonality = SetPreferedPersonality();
            int houseActivityLevelInt = SetActivityLvl();
            newAccount = new CreateAdoptee();
            newAccount.StartCreate(FirstName, LastName, UserName, Password, PreferedAnimalPersonality, houseActivityLevelInt);
            //SEND INFO TO DATABASE
            //Console.WriteLine("EndRun");
            //Console.ReadLine();
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

        static string SetPreferedPersonality()
        {
            Console.WriteLine("what personality are you looking for\n1 = docile\n2 = energetic\n3 = search for both");
            string PreferedAnimalPersonality = Console.ReadLine();
            PreferedAnimalPersonality = PreferedPersonalitySwitch(PreferedAnimalPersonality);
            return PreferedAnimalPersonality;
        }

        static int SetActivityLvl()
        {
            Console.WriteLine("How active is your household 1 - 10? (1 being calm 10 being vary active)");
            string houseActivityLevelString = Console.ReadLine();
            int houseActivityLevelInt = CheckHouseHold(houseActivityLevelString);
            ///////SETTING UP ADOPTEE// NEED TO MAKE A SEPERATE ONE FOR EMPLOYEE AND GIVE A WAY TO CREATE NEW EMPLOYEES VIA A PASSWORD??
            return houseActivityLevelInt;
        }    

        
        static string PreferedPersonalitySwitch(string userInput)
        {
            string PreferedAnimalPersonality = "both";
            switch (userInput)
            {
                case "1":
                    PreferedAnimalPersonality = "docile";
                    return PreferedAnimalPersonality;
                case "2":
                    PreferedAnimalPersonality = "energetic";
                    return PreferedAnimalPersonality;
                case "3":
                    PreferedAnimalPersonality = "both";
                    return PreferedAnimalPersonality;
                default:
                    Console.WriteLine("sorry try again.");
                    Console.ReadLine();
                    PreferedPersonalitySwitch(userInput);
                    return PreferedAnimalPersonality;
            }
        }
        static int CheckHouseHold(string activityLvl)
        {
            int newActivityLvl;
            try
            {
                newActivityLvl = int.Parse(activityLvl);
                return newActivityLvl;
            }
            catch
            {
                int empty = 0;
                Console.WriteLine("Sorry that wasnt a number 1 - 10 try again.");
                Console.ReadLine();
                SetActivityLvl();
                return empty;
            }
        }
    }
}

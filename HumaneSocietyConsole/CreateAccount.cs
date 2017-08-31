using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyConsole
{
    static class CreateAccount
    {
        public static void SetUser()
        {
            string tempFirstName;
            string tempLastName;
            string PreferedAnimalPersonality;
            string houseActivityLevel;

            Console.WriteLine("Enter Your first name.");
            tempFirstName = Console.ReadLine();

            Console.WriteLine("Enter Your last name.");
            tempLastName = Console.ReadLine();

            Console.WriteLine("what personality are you looking for\n1 = docile\n2 = energetic\n 3 = search for both");
            PreferedAnimalPersonality = Console.ReadLine();
            PreferedAnimalPersonality = PreferedPersonalitySwitch(PreferedAnimalPersonality);

            Console.WriteLine("How active is your household 1 - 10? (1 being calm 10 being vary active)");
            houseActivityLevel = Console.ReadLine();
            houseActivityLevel = CheckHouseHold(houseActivityLevel);
            
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
                Console.WriteLine("How active is your household 1 - 10? (1 being calm 10 being vary active)");
                string temp = Console.ReadLine();
                CheckHouseHold(temp);
                return empty;
            }
            
        }
    }
}

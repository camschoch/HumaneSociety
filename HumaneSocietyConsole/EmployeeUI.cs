using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyConsole
{
    static class EmployeeUI
    {
        public static void MainMenu(employee personInfo)
        {
            Console.WriteLine("welcome employee " + personInfo.First_Name);
            Console.WriteLine("would you like to add an animal, find an animals room, set status, check shots\n1 = add animal\n2 = change status\n3 = animal shots\n4 = check animal rooms\n5 = search amount of food needed");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    AddAnimal();
                    MainMenu(personInfo);
                    break;
                case "2":
                    var aniamlsList = Quary.AnimalStatus();                    
                    Quary.DisplayNotAdopted(aniamlsList);
                    Quary.DisplayAdopted(aniamlsList);
                    Console.ReadLine();
                    Quary.SetStatus();
                    MainMenu(personInfo);
                    break;
                case "3":
                    Quary.CheckAnimalShots();
                    MainMenu(personInfo);
                    break;
                case "4":
                    Quary.CheckRoom();
                    MainMenu(personInfo);
                    break;
                case "5":
                    Quary.CheckAmountOfFood();
                    MainMenu(personInfo);
                    break;
                //case "6":
                //    Quary.Import();
                //    break;
                default:
                    Console.WriteLine("Sorry try again.");
                    Console.ReadLine();
                    MainMenu(personInfo);
                    break;
            }
        }
        static void AddAnimal()
        {
            string name = GetName();
            bool adoptionStatus = SetAdoptionStatus();
            string species = SetSpecies();
            string breed = SetBreed();
            bool gender = SetGender();
            int roomNumber = SetRoomNumber();
            string personality = SetPersonality();
            int activityLvl = SetActivityLvl();
            int foodAmount = SetFoodAmount();
            DateTime shots = SetShots();
            int price = SetPrice();
            Quary.Start(name, adoptionStatus, species, breed, gender, roomNumber, personality, activityLvl, foodAmount, shots, price);
        }

        static string GetName()
        {
            Console.WriteLine("What is the name of the animal?");
            string userInput = Console.ReadLine();
            return userInput;
        }
        static string SetSpecies()
        {
            Console.WriteLine("What species is the animal you would like to add? 1 = cat, 2 = dog , 3 = bird, 4 = lizard, 5 = bunny");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    return "cat";                    
                case "2":
                    return "dog";
                case "3":
                    return "bird";
                case "4":
                    return "lizard";
                case "5":
                    return "bunny";
                default:
                    Console.WriteLine("Sorry try again.");
                    Console.ReadLine();
                    return "unknown";
            }
        }
        static string SetBreed()
        {
            Console.WriteLine("what Bread is the animal? (type unknown if unsure and mixed if mixed)");
            string userInput = Console.ReadLine();
            return userInput;
        }
        static int SetRoomNumber()
        {
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            Console.WriteLine("What room will the animal be staying in?");
            int userInput = int.Parse(Console.ReadLine());
            foreach (var item in context.animals)
            {
                if(item.Room == userInput)
                {
                    Console.WriteLine("sorry that room is taken try another one.");
                    Console.ReadLine();
                    SetRoomNumber();
                }
            }
            return userInput;
        }
        static string SetPersonality()
        {
            Console.WriteLine("what is the animals personality?\n1 = docile\n2 = energetic");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    return "docile";
                case "2":
                    return "energetic";
                default:
                    Console.WriteLine("Sorry try again.");
                    Console.ReadLine();
                    SetPersonality();
                    return "unkown";
            }
        }
        static int SetActivityLvl()
        {
            Console.WriteLine("1 - 10 what is the recommended house activity level for this animal");
            string userInput = Console.ReadLine();
            try
            {
                int intUserInput = int.Parse(userInput);
                if (intUserInput > 0 && intUserInput < 10)
                {
                    return intUserInput;
                }
            }
            catch
            {
                Console.WriteLine("Sorry try again");
                Console.ReadLine();
                SetActivityLvl();
            }
            return 0;
        }
        static bool SetAdoptionStatus()
        {
            Console.WriteLine("is the animal adopted?\n1 = yes\n2 = no");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    return true;
                case "2":
                    return false;
                default:
                    Console.WriteLine("Sorry try again");
                    Console.ReadLine();
                    SetAdoptionStatus();
                    return false;
            }
        }
        static int SetPrice()
        {
            Console.WriteLine("How much does the animal cost? (whole numbers only)");
            string userInput = Console.ReadLine();
            try
            {
                int intPrice = int.Parse(userInput);
                return intPrice;
            }
            catch
            {
                Console.WriteLine("Sorry try again.");
                Console.ReadLine();
                SetPrice();
            }
            return 0;
        }
        static DateTime SetShots()
        {
            Console.WriteLine("When are the aniamals shots good until? (if past enter yesterdays date)(year/month/day)");
            string userInput = Console.ReadLine();
            DateTime temp = Convert.ToDateTime(userInput);
            return temp;
        }
        static int SetFoodAmount()
        {
            Console.WriteLine("how many cups of food does the aniaml eat a day (whole numbers only)");
            string userInput = Console.ReadLine();
            try
            {
                int intUserInput = int.Parse(userInput);
                return intUserInput;
            }
            catch
            {
                Console.WriteLine("Sorry try again");
                Console.ReadLine();
                SetFoodAmount();
            }
            return 0;
        }
        static bool SetGender()
        {
            Console.WriteLine("What gender is the animal\n1 = male\n2 = female");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    return true;
                case "2":
                    return false;
                default:
                    Console.WriteLine("Sorry try again.");
                    Console.ReadLine();
                    return false;
            }
        }
    }
}

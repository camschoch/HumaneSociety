using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyConsole
{
    static class AdopteeUI
    {
        public static void MainMenu(adopter personInfo)
        {
            Console.WriteLine("welcome " + personInfo.First_Name);
            Console.ReadLine();
            Console.WriteLine("Would you like to search for an animal or adopt one?\n1 = find\n2 = adopt");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    List<animal> searchedAnimals = new List<animal>();
                    SearchAnimals(searchedAnimals);
                    MainMenu(personInfo);
                    break;
                case "2":
                    //AdoptAnimal();
                    MainMenu(personInfo);
                    break;               
                default:
                    Console.WriteLine("Sorry try again.");
                    Console.ReadLine();
                    MainMenu(personInfo);
                    break;
            }
        }
        public static void SearchAnimals(List<animal> searchedAnimal)
        {
            Console.WriteLine("What ctriteria would you like to search by?\n1 = species\n2 = price\n3 = personality\n4 = household activity level\n5 = finished");
            string userInput = Console.ReadLine();
            Quary.SearchAnimals(userInput, searchedAnimal);
        }
    }
}

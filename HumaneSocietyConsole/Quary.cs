using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyConsole
{
    static class Quary
    {
        public static void CreateEmployee(string FirstName, string LastName, string UserName, string Password)
        {
            employee EMPLOYEE = new employee();
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            EMPLOYEE.First_Name = FirstName;
            EMPLOYEE.Last_Name = LastName;
            EMPLOYEE.Username = UserName;
            EMPLOYEE.Pass = Password;
            context.employees.InsertOnSubmit(EMPLOYEE);
            context.SubmitChanges();
        }
        public static void CreateAdoptee(string FirstName, string LastName, string UserName, string Password, string PreferedAnimalPersonality, int houseActivityLevelInt)
        {
            adopter ADOPTER = new adopter();
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            ADOPTER.First_Name = FirstName;
            ADOPTER.Last_Name = LastName;
            ADOPTER.Username = UserName;
            ADOPTER.Pass = Password;
            ADOPTER.Personality = PreferedAnimalPersonality;
            ADOPTER.Household_Activity = houseActivityLevelInt;
            context.adopters.InsertOnSubmit(ADOPTER);
            context.SubmitChanges();
        }
        static public void Start(string name, bool adoptionStatus, string species, string breed, bool gender, int roomNumber, string personality, int activityLvl, int foodAmount, DateTime shots, int price)
        {
            animal ANIMAL = new animal();
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            ANIMAL.Name = name;
            ANIMAL.Current_Status = adoptionStatus;
            ANIMAL.Species = species;
            ANIMAL.Breed = breed;
            ANIMAL.Gender = gender;
            ANIMAL.Room = roomNumber;
            ANIMAL.Personality = personality;
            ANIMAL.Household_Activity = activityLvl;
            ANIMAL.Food_Amount = foodAmount;
            ANIMAL.Shots_Date = shots;
            ANIMAL.Price = price;
            context.animals.InsertOnSubmit(ANIMAL);
            context.SubmitChanges();
        }
        static public List<List<animal>> AnimalStatus()
        {
            List<animal> notAdopted = new List<animal>();
            List<animal> adopted = new List<animal>();
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            foreach (var animal in context.animals)
            {
                if (animal.Current_Status == false)
                {
                    notAdopted.Add(animal);
                }
                else if (animal.Current_Status == true)
                {
                    adopted.Add(animal);
                }
            }
            List<List<animal>> animalsList = new List<List<animal>>();
            animalsList.Add(notAdopted);
            animalsList.Add(adopted);
            return animalsList;
        }
        static public void DisplayNotAdopted(List<List<animal>> animals)
        {
            var notAdopted = animals[0];
            foreach(var item in notAdopted)
            {
                Console.WriteLine(item.Animal1 + " " + item.Name + " " + item.Species + " Not adopted.");
            }
        }
        static public void DisplayAdopted(List<List<animal>> animals)
        {
            var Adopted = animals[1];
            foreach (var item in Adopted)
            {
                Console.WriteLine(item.Animal1 + " " + item.Name + " " + item.Species + " Adopted!");
            }
        }
        static public void SetStatus()
        {
            Console.WriteLine("Please enter the ID of the animal you would like to change the status of.");
            string userInput = Console.ReadLine();
            int intInput = int.Parse(userInput);
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            foreach (var item in context.animals)
            {
                if (item.Animal1 == intInput)
                {
                    Console.WriteLine("Are you changing this animal to adopted or not adopted\n 1 = adopted\n 2 = not adopted");
                    string adoptionStatus = Console.ReadLine();
                    switch (adoptionStatus)
                    {
                        case "1":
                            item.Current_Status = true;
                            context.SubmitChanges();
                            break;
                        case "2":
                            item.Current_Status = false;
                            context.SubmitChanges();
                            break;
                        default:
                            Console.WriteLine("sorry try again.");
                            Console.ReadLine();
                            SetStatus();
                            break;
                    }
                }
                EmployeeUI.MainMenu();
            }
        }
    }
}

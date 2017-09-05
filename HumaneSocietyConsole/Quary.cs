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
    }
}

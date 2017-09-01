using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyConsole
{
    class CreateEmployee : CreateAccount
    {
        public override void StartCreate(string FirstName, string LastName, string UserName, string Password, string PreferedAnimalPersonality, int houseActivityLevelInt)
        {
            AddFirstName(FirstName);
            AddLastName(LastName);
            AddUserName(UserName);
            AddPass(Password);
        }
        void AddFirstName(string firstName)
        {
            adopter ADOPTER = new adopter();
            ADOPTER.First_Name = firstName;
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            context.adopters.InsertOnSubmit(ADOPTER);
            context.SubmitChanges();
        }
        void AddLastName(string lastName)
        {
            adopter ADOPTER = new adopter();
            ADOPTER.First_Name = lastName;
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            context.adopters.InsertOnSubmit(ADOPTER);
            context.SubmitChanges();
        }
        void AddUserName(string userName)
        {
            adopter ADOPTER = new adopter();
            ADOPTER.First_Name = userName;
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            context.adopters.InsertOnSubmit(ADOPTER);
            context.SubmitChanges();
        }

        void AddPass(string pass)
        {
            adopter ADOPTER = new adopter();
            ADOPTER.First_Name = pass;
            LINQtoSQLDataContext context = new LINQtoSQLDataContext();
            context.adopters.InsertOnSubmit(ADOPTER);
            context.SubmitChanges();
        }
    }
}

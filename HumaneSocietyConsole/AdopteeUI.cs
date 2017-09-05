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
        }
    }
}

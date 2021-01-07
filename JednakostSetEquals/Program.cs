using System;
using System.Collections.Generic;

namespace JednakostSetEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> gradovi = new HashSet<string>() {"Beograd", "Nis", "Kragujevac", "Subotica", "Novi Sad"};
            HashSet<string> gradoviNaBalkanu = new HashSet<string>() {"Zagreb", "Beograd", "Kragujevac", "Podgorica", "Novi Sad"};

            string[] velikiGradovi = new string[] {"Nis", "Kragujevac", "Novi Sad", "Subotica", "Beograd"};
            
            Console.WriteLine("gradovi SetEquals gradoviNaBalkanu: " + gradovi.SetEquals(gradoviNaBalkanu));//false jer ima razlike
            Console.WriteLine("gradoviUSrbiji SetSquals velikiGradovi: " + gradovi.SetEquals(velikiGradovi));//true jer nema

            Console.ReadLine();
        }
    }
}
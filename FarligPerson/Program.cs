using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarligPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Anmälan a = new Anmälan();
            a.Report();

            FarligPerson f = new FarligPerson(a.getNamn(),a.getÅlder(),a.getNat(),a.getKniv(),a.getKriminell(),a.getBarn());
            string n = f.GetNamn();
            f.PrintInfo();

            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta.");
            Console.ReadKey();
        }


    }
}

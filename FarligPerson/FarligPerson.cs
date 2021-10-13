using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarligPerson
{
    class FarligPerson : Person
    {
        bool harKniv;
        bool gillarBarn;
        bool ärKriminell;

        public FarligPerson(string n, string å, string nat, bool Kniv, bool Kriminell, bool Barn): base(n,å,nat)
        {
            harKniv = Kniv;
            ärKriminell = Kriminell;
            gillarBarn = Barn;

            if (harKniv)
            {
                ärKriminell = true;
            }
            else if (gillarBarn)
            {
                ärKriminell = true;
            }

        }

        public void PrintInfo()
        {
            Console.WriteLine("Namn: " + base.GetNamn());
            Console.WriteLine("Ålder: " + base.GetÅlder());
            Console.WriteLine("Nationalitet: " + base.GetNationalitet());

            Console.WriteLine();

            if (harKniv && gillarBarn)
            {
                Console.WriteLine(base.GetNamn() + " är kriminell, har kniv och gillar barn.");
            }
            else if (gillarBarn)
            {
                Console.WriteLine(base.GetNamn() + " är kriminell och gillar barn.");
            }
            else if (harKniv)
            {
                Console.WriteLine(base.GetNamn() + " är kriminell och har kniv.");
            }
            else if (ärKriminell)
            {
                Console.WriteLine(base.GetNamn() + " är kriminell.");
            }
        }

       
    }
}

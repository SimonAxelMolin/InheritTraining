using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarligPerson
{
    class Anmälan
    {
        string basNamn;
        string basÅlder;
        string basNat;
        bool basKniv;
        bool basKriminell;
        bool basBarn;

        public string getNamn()
        {
            return basNamn;
        }

        public string getÅlder()
        {
            return basÅlder;
        }

        public string getNat()
        {
            return basNat;
        }

        public bool getKniv()
        {
            return basKniv;
        }

        public bool getKriminell()
        {
            return basKriminell;
        }

        public bool getBarn()
        {
            return basBarn;
        }

        public void Report()
        {
            Console.WriteLine("Vänligen skriv namnet på personen som skall anmälas.");
            basNamn = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Vänligen skriv åldern på personen som skall anmälas.");
            basÅlder = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Vänligen skriv nationaliteten på personen som skall anmälas. t.ex svensk, fransk, engelsk.");
            basNat = Console.ReadLine();
            Console.WriteLine();

            Console.Clear();

            Console.WriteLine("Har personen som anmäls kniv? y/n");
            string knivSvar = Console.ReadLine();
            if (knivSvar == "y")
            {
                basKniv = true;
            }
            else if (knivSvar == "n")
            {
                basKniv = false;
            }
            else
            {
                Console.WriteLine("Vänligen svara med y eller n.");
                knivSvar = Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("Är personen som skall anmälas kriminell? y/n");
            string krimSvar = Console.ReadLine();
            if (krimSvar == "y")
            {
                basKriminell = true;
            }
            else if (krimSvar == "n")
            {
                basKriminell = false;
            }
            else
            {
                Console.WriteLine("Vänligen svara med y eller n.");
                krimSvar = Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("Gillar personen som ska anmälas barn? y/n");
            string barnSvar = Console.ReadLine();
            if (barnSvar == "y")
            {
                basBarn = true;
            }
            else if (barnSvar == "n")
            {
                basBarn = false;
            }
            else
            {
                Console.WriteLine("Vänligen svara med y eller n.");
                barnSvar = Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("Tack för din anmälan.");
            Console.WriteLine();

        }
    }
}

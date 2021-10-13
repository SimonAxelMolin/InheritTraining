using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarligPerson
{
    class Person
    {
        private string namn;
        private string ålder;
        private string nationalitet;

        public Person(string namn, string ålder, string nationalitet)
        {
            this.namn = namn;
            this.ålder = ålder;
            this.nationalitet = nationalitet;
        }

        public string GetNamn()
        {
            return namn;
        }

        public string GetÅlder()
        {
            return ålder;
        }

        public string GetNationalitet()
        {
            return nationalitet;
        }
    }
}

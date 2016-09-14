using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deothan.dk.des.csharp.Interfaces;

namespace deothan.dk.des.csharp.Implementation
{
    class Cow : FourLeggedAnimal
    {
        private string race = "Cow";

        public string GetRace()
        {
            return this.race;
        }

        public string[] GetFourFeetNames()
        {
            var name = "John";
            string[] names = { name, "Ben", "Slow", "Poke"};
            return names;
        }
    }
}

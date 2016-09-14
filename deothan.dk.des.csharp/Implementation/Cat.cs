using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using deothan.dk.des.csharp.Interfaces;

namespace deothan.dk.des.csharp.Implementation
{
    class Cat : FourLeggedAnimal
    {
        public string GetRace()
        {
            return this.GetType().FullName;
        }

        public string[] GetFourFeetNames()
        {
            return new [] {"Benny", "John", "Liz", "Watt"};
        }
    }
}

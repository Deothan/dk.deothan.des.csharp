using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deothan.dk.des.csharp.Interfaces;

namespace deothan.dk.des.csharp.Implementation
{
    class Ostrich : TwoLeggedAnimal
    {
        public string value { get; set; }

        public string GetRace()
        {
            return "Ostrich";
        }

        public string[] GetTwoFeetNames()
        {
            return new [] {"one", "two"};
        }
    }
}

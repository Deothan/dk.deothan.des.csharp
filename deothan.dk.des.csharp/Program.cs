
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deothan.dk.des.csharp.Implementation;
using deothan.dk.des.csharp.Interfaces;
using static System.Console;
using Shortcut = System.Console;

namespace deothan.dk.des.csharp
{
    class Program
    {
        public string test { get; set; }
        static void Main(string[] args)
        {
            var random = new Random();

            Animal picked = null;
            TwoLeggedAnimal twoLeggedAnimal = null;
            FourLeggedAnimal fourLeggedAnimal = null;

            Dictionary<string, Animal> animals = new Dictionary<string, Animal>();
            animals.Add("cat", picked);
            animals.Add("Cow", fourLeggedAnimal);
            animals.Add("Ostrich", twoLeggedAnimal);


            WriteLine("Welcome");
            Shortcut.WriteLine("To the animal picker");
            var line = ReadLine();
            while (line != null && !line.ToLower().Equals("exit"))
            {
                switch (line)
                {
                    case "ostrich":                        
                        twoLeggedAnimal = new Ostrich();
                        Animal animal = animals["Ostrich"];
                        WriteLine(twoLeggedAnimal.GetRace());
                        Shortcut.WriteLine(animal.GetRace());
                        foreach (var twoFeetName in twoLeggedAnimal.GetTwoFeetNames())
                        {
                            WriteLine(twoFeetName);
                        }
                        break;
                    case "cow":
                        fourLeggedAnimal = new Cow();
                        WriteLine(fourLeggedAnimal.GetRace());
                        foreach (var fourFeetName in fourLeggedAnimal.GetFourFeetNames())
                        {
                            WriteLine(fourFeetName);
                        }
                        break;
                    case "cat":
                        picked = new Cat();
                        WriteLine(picked.GetRace());
                        break;
                    case "random":
                        WriteLine(random.Next(1, 4));
                        break;
                    default:
                        WriteLine("Animal not found!");
                        break;
                }
                line = ReadLine();
            }
        }
    }
}

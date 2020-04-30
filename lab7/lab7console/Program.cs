using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab7lib;

namespace lab7console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();

            Archer archer = new Archer("Łukasz");
            Wizzard wizzard = new Wizzard("Marcin");
            Warrior warrior = new Warrior("Kamil");
            Archer archer2 = new Archer("Krzysiek");

            characters.Add(archer);
            characters.Add(wizzard);
            characters.Add(warrior);
            characters.Add(archer2);
        }
    }
}

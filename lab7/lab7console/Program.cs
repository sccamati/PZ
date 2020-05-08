using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab7lib;
using lab7lib.Interfaces;

namespace lab7console
{
    class Program
    {
        static List<Character> characters = new List<Character>();
        static void Main(string[] args)
        {
            

            Archer archer = new Archer("Łukasz");
            Wizzard wizzard = new Wizzard("Marcin");
            Warrior warrior = new Warrior("Kamil");
            Archer archer2 = new Archer("Krzysiek");

            characters.Add(archer);
            characters.Add(wizzard);
            characters.Add(warrior);
            characters.Add(archer2);

            Dragon dragon = new Dragon { Armor = 10, Damage = 40, Dexterity = 34, Exp = 12000, Hp = 400, Intelligence = 40, Lvl = 12, Maxhp = 400, Name = "Stefan", Strength = 30 };
            dragon.OnFireBreathed += (damage) => characters.ForEach(d => d.TakeDamage(damage));

            archer.AddExperience(200);
            StaticClass.AddExperience(wizzard, 300);

            var champions = characters.Where(c => c.Lvl > 1).Select(c => new
            {
                c.Name,
                c.Lvl,
            });

            foreach (var champ in champions)
            {
                Console.WriteLine(champ);
            }

            while(!dragon.IsDead())
            {
                int i = 0;
                foreach (var character in characters)
                {
                    if (character.IsDead())
                    {
                        i++;
                        if(i == characters.Count)
                        {
                            break;
                        }
                    }
                }
                Battle(characters, dragon);
            }
            Console.ReadLine();
        }

        private static void Battle(List<Character> characters, Dragon dragon)
        {
            Console.WriteLine("Hero's Round");
            foreach (var character in characters)
            {
                if (dragon.IsDead())
                {
                    break;
                }
                Console.WriteLine($"{character.Name} Attacks dragon and deal {character.DamagePerRound}");
                if(character is Wizzard)
                {
                    
                    dragon.TakeDamage(Spell((Wizzard)character, 20));
                }
                else
                {
                    dragon.TakeDamage(character.DamagePerRound);
                }

                Console.WriteLine($"Dragon's health {dragon.Hp}");
            }


            if (dragon.IsDead())
            {
                Console.WriteLine("Heroes win");
            }
            else
            {
                Console.WriteLine("Dragon's round");
                Spell(dragon, 30);
                foreach (var character in characters)
                {
                    Console.WriteLine($"{character.Name} have {character.Hp}");
                    if (character.Hp < (character.Maxhp * 0.2))
                    {
                        character.DrinkHealthPotion();
                    }
                }
            }
           
        }

        private static int Spell(IMagic character, int MP) {
            try
            {
                return character.CastSpell(MP);
            }
            catch(ManaException e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }
        


    }
}

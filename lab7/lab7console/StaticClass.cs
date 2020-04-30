using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab7lib;
using lab7lib.Interfaces;

namespace lab7console
{
    static class StaticClass
    {
        public static void DrinkHealthPotion(this Character character)
        {
            character.Hp = character.Maxhp;
        }

        public static void IsDead(this Character character)
        {
            if (character.Hp <= 0)
            {
                Console.WriteLine("Dead");
            }
            else
            {
                Console.WriteLine("Alive");
            }
        }
        
        public static void AddExperience(this Character character, int exp)
        {
            character.Exp += exp;
            if((character.Lvl*100)<= character.Exp)
            {
                character.LvlUp();
            }
        }

        public static void RegenerateMana(this Wizzard wizzard, int mp)
        {
            if((wizzard.Mp + mp) > wizzard.MaxMp)
            {
                wizzard.Mp = wizzard.MaxMp;
            }
            else
            {
                wizzard.Mp += mp;
            }
            
        }

        public static void Disarmor(this Character character, int value)
        {
            character.Damage -= value;
        }

        public static void RemoveArmor(this Character character, int value)
        {
            character.Armor -= value;
        }

        public static void Meditation (this IMagic magic)
        {
            magic.CurrentMP = magic.MaxMP;
        }
    }
}

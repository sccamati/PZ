using lab8lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8console
{
    class Program
    {
        static void Main(string[] args)
        {
            MageGuild guild = null;
            try
            {
                guild = initializeGuild();
            }
            catch(MageExistException e)
            {
                Console.WriteLine(e);
            }



            Write("AllMAges");
            guild.AllMages();

            Write("ExperiencedMages");
            guild.ExperiencedMages(10);

            Write("TalendetMages");
            guild.TalentedMages(120);

            Write("AllCombatMages");
            guild.AllCombatMages();

            Write("MagesWithMostSpells");
            guild.MageWithMostSpells(3);

            Write("VersatileMages");
            guild.VersatileMages();

            Write("MostSpells");
            guild.MostSpells();

            Write("CheckSpells");
            guild.CheckSpells();

            Write("SpellsByType");
            guild.SpellsByType(SpellType.Offensive);

            Write("SpellsByNameAndType");
            guild.SpellsByNameAndType("Gandalf", SpellType.Offensive);

            Write("CountSpells");
            guild.CountSpells();

            Write("CountMagesSpells");
            guild.CountMagesSpells("Gandalf");

            Write("MostPowerfullMages");
            guild.MostPowerfullMages();

            Write("QuidditchReady");
            guild.QuidditchReady();

            Write("CheckPassOut");
            guild.CheckPassOut();

            Write("OnMission");
            guild.OnMission();

            Write("Rozszerzeniowe 1");
            guild.Strongest1();

            Write("Rozszerzeniowe 2");
            guild.Strongest2();

            Write("Rozszerzeniowe 3");
            guild.Strongest3();

            Write("Rozszerzeniowe 4");
            guild.Strongest4();

            Write("Rozszerzeniowe 5");
            guild.Strongest5();

            Write("Rozszerzeniowe 6");
            guild.Strongest6();


        }

        private static MageGuild initializeGuild()
        {
            MageGuild guild = new MageGuild();
            guild.AddMage(new Mage
            {
                Name = "Gandalf",
                Level = 100,
                Experience = 7000000,
                Strength = 15,
                Dextirity = 16,
                Inteligence = 21,
                HP = 0,
                MaxHP = 200,
                MP = 400,
                MaxMP = 400,
                Damage = 27,
                PhysicalResistance = 50,
                FireResistance = 50,
                IceResistance = 50,
                PoisonResistance = 50,
                SpellBook = new SpellBook
                {
                    new Spell { Name = "Fireball", Type = SpellType.Offensive, ManaCost = 25, CoolDown = 10, Effect = 75 },
                    new Spell { Name = "Light Ray", Type = SpellType.Offensive, ManaCost = 25, CoolDown = 10, Effect = 225 },
                    new Spell { Name = "Force Push", Type = SpellType.Offensive, ManaCost = 25, CoolDown = 10, Effect = 20 },
                    new Spell { Name = "Barrier", Type = SpellType.Deffensive, ManaCost = 20, CoolDown = 15, Effect = 10 },
                    new Spell { Name = "Mass Heal", Type = SpellType.Healing, ManaCost = 30, CoolDown = 8, Effect = 100 }
                }
            });
            guild.AddMage(new Mage
            {
                Name = "Harry Potter",
                Level = 50,
                Experience = 1000000,
                Strength = 12,
                Dextirity = 14,
                Inteligence = 20,
                HP = 150,
                MaxHP = 150,
                MP = 250,
                MaxMP = 250,
                Damage = 15,
                PhysicalResistance = 10,
                FireResistance = 10,
                IceResistance = 10,
                PoisonResistance = 10,
                SpellBook = new SpellBook
                {
                    new Spell  { Name = "Fireball", Type = SpellType.Offensive, ManaCost = 25, CoolDown = 10, Effect = 75 },
                    new Spell { Name = "Barrier", Type = SpellType.Deffensive, ManaCost = 20, CoolDown = 15, Effect = 10 },
                }
            });
            guild.AddMage(new Mage
            {
                Name = "Bartek",
                Level = 80,
                Experience = 6000000,
                Strength = 12,
                Dextirity = 14,
                Inteligence = 19,
                HP = 100,
                MaxHP = 100,
                MP = 350,
                MaxMP = 350,
                Damage = 25,
                PhysicalResistance = 45,
                FireResistance = 45,
                IceResistance = 45,
                PoisonResistance = 45,
                SpellBook = new SpellBook
                {
                    new Spell { Name = "Fireball", Type = SpellType.Offensive, ManaCost = 25, CoolDown = 10, Effect = 75 },
                    new Spell { Name = "Light Ray", Type = SpellType.Offensive, ManaCost = 25, CoolDown = 10, Effect = 225 },
                    new Spell { Name = "Force Push", Type = SpellType.Offensive, ManaCost = 25, CoolDown = 10, Effect = 20 },
                    new Spell { Name = "Barrier", Type = SpellType.Deffensive, ManaCost = 20, CoolDown = 15, Effect = 10 },
                    new Spell { Name = "Mass Heal", Type = SpellType.Healing, ManaCost = 30, CoolDown = 8, Effect = 100 }
                }
            });
            guild.AddMage(new Mage
            {
                Name = "Marcin",
                Level = 1,
                Experience = 1,
                Strength = 2,
                Dextirity = 3,
                Inteligence = 4,
                HP = 10,
                MaxHP = 20,
                MP = 50,
                MaxMP = 100,
                Damage = 5,
                PhysicalResistance = 0,
                FireResistance = 100,
                IceResistance = 10,
                PoisonResistance = 10,
                SpellBook = new SpellBook
                {
                    new Spell  { Name = "Fireball", Type = SpellType.Offensive, ManaCost = 25, CoolDown = 10, Effect = 75 },
                    new Spell { Name = "Barrier", Type = SpellType.Deffensive, ManaCost = 20, CoolDown = 15, Effect = 10 },
                }
            });
            return guild;
        }
        private static void Write(String msg)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}

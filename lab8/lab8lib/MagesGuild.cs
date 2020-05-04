using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8lib
{
    public class MagesGuild : List<Mage>
    {
        public override string ToString()
        {
            String mages = "";
            foreach (var item in this)
            {
                mages += item.ToString() + "\n";
            }
            return mages;
        }

        public void AllMages()
        {
            var result = this.OrderBy(m => m.Name);

            foreach (var mage in result)
            {
                mage.ToString();
            }
        }

        public void ExperiencedMages(int lvl)
        {
            var result = this.Where(m => m.Level > lvl)
                .OrderBy(m => m.Level);

            foreach (var mage in result)
            {
                mage.ToString();

            }
        }

        public void TalentedMages(int lvl)
        {
            var result = this.Where(m => m.Level <= lvl && m.Inteligence > 20)
                .OrderByDescending(m => m.Inteligence);

            foreach (var mage in result)
            {
                mage.ToString();
            }
        }

        public void AllCombatMages()
        {
            var result = this.Where(m => m.Level > 2 && m.Dextirity > 10)
                .Sum(m => m.MaxMP);

            Console.WriteLine(result);
        }

        public void MageWithMostSpells(int NumberOfSpells)
        {
            var result = this.Where(m => m.SpellBook.Count >= NumberOfSpells)
                .OrderByDescending(m => m.SpellBook.Count)
                .Select(m => $"Name: {m.Name} Number of spells: {m.SpellBook.Count} MP: {m.MP}");

            foreach (var mage in result)
            {
                Console.WriteLine(result);
            }
        }

        public void VersatileMages()
        {
            var result = this.Select(x => new
            {
                x.Name,
                x.Level,
                average = (x.Dextirity + x.Strength + x.Inteligence) / 3
            }).OrderByDescending(x => x.average);

            foreach (var mage in result)
            {
                Console.WriteLine(mage);
            }
        }

        public void MostSpells()
        {
            var spells = this.Max(m => m.SpellBook.Count);
            var mages = this.Where(m => m.SpellBook.Count.Equals(spells));

            foreach (var mage in mages)
            {
                Console.WriteLine(mage);
            }
        }


        public void CheckSpells()
        {
            var spells = this.SelectMany(s => s.SpellBook).Distinct();

            foreach (var spell in spells)
            {
                spell.ToString();
            }
        }

        public void SpellsByType(Type type)
        {
            var spells = this.SelectMany(s => s.SpellBook).Where(s => s.SpellType.Equals(type)).Distinct();
            Console.WriteLine($"all {type} spells");
            foreach (var spell in spells)
            {
                spell.ToString();
            }
        }

        public void SpellsByNameAndType(String name, Type type)
        {
            var spells = this.Single(m => m.Name.Equals(name))
                .SpellBook.Where(s => s.SpellType.Equals(type));

            foreach (var spell in spells)
            {
                spell.ToString();
            }
        }

        public void CountSpellsByType (Type type)
        {
            var spells = this.SelectMany(m => m.SpellBook).Distinct().GroupBy(s => s.SpellType).Select(s => new
            {
                s.Key,
                Count = s.Count()
            });

            foreach (var spell in spells)
            {
                Console.WriteLine($"{spell.Key} {spell.Count} ");
            }
        }

        public void MostPowerfullMages()
        {
            var result = this.OrderByDescending(m => m.Level).ThenByDescending(m => m.Experience).Skip(1).Take(2).Select(m => new
            {
                m.Name,
                m.Level
            });

            foreach (var mage in result)
            {
                Console.WriteLine(mage);
            }
        }

        public void QuidditchReady()
        {
            var result = this.All(m => m.MaxHP == m.HP && m.MaxMP == m.MP);

            if (result)
            {
                Console.WriteLine("Ready");
            }
            else
            {
                Console.WriteLine("Not ready");
            }
        }

        public void CheckLostConsciousness()
        {
            var result = this.Any(m => m.HP == 0);
            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        public void OnMission()
        {

        }

    }
    
}

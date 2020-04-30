using lab7lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7lib
{
    public class Wizzard : Character, IMagic
    {
		public int Mp { get; set; }

		public int MaxMp { get; set; }
		public int MaxMP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int CurrentMP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Wizzard(string name, int lvl, int exp, int strength, int dexterity, int intelligence, int hp, int maxhp, int damage, int armor, int mp, int mpMax) : base(name, lvl, exp, strength, dexterity, intelligence, hp, maxhp, damage, armor)
		{
			this.Mp = mp;
			this.MaxMp = MaxMp;
		}

		public Wizzard(string name) : base(name)
		{
			Lvl = 1;
			Exp = 0;
			Strength = 3;
			Dexterity = 6;
			Intelligence = 20;
			Hp = 80;
			Maxhp = 80;
			Damage = 35;
			Armor = 3;
			Mp = 100;
			MaxMp = 100;
		}

		public override string ToString()
		{
			return base.ToString() + $" MP: {Mp} MaxMP{Maxhp}";
		}

		public override void LvlUp()
		{
			Lvl++;
			Intelligence += 4;
			Maxhp += 10;
			MaxMp += 20;
			Damage += 2;

		}

		public int CastSpell(int MP)
		{
			if(MP > Mp)
			{
				throw new ManaException("Za mało many");
			}
			else
			{
				Mp -= MP;
			}
			return MP/2;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7lib
{
    public class Archer : Character
    {
		public int ChanceToDodge { get; set; }


		public Archer(string name, int lvl, int exp, int strength, int dexterity, int intelligence, int hp, int maxhp, int damage, int armor, int chanceToDodge) : base(name, lvl, exp, strength, dexterity, intelligence, hp, maxhp, damage, armor)
		{
			this.ChanceToDodge = chanceToDodge;

		}

		public Archer(string name) : base(name)
		{
			Lvl = 1;
			Exp = 0;
			Strength = 6;
			Dexterity = 12;
			Intelligence = 7;
			Hp = 100;
			Maxhp = 100;
			Damage = 20;
			Armor = 8;
			ChanceToDodge = 60;
		}

		public override string ToString()
		{
			return base.ToString() + $" Chance to Dodge: {ChanceToDodge}";
		}

		public override void LvlUp()
		{
			Lvl++;
			Dexterity += 2;
			Damage += 4;
			Maxhp += 15;
			ChanceToDodge += 2;

		}

		public override void TakeDamage(int damage)
		{
			Random random = new Random();
			int randomNumber = random.Next(1, 101);
			if (ChanceToDodge > randomNumber)
			{
				base.TakeDamage(damage);
			}
			
		}
	}
}

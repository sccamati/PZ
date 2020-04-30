using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7lib
{
    public class Warrior : Character
    {
		public int AttacksPerRound { get; set; }


		public Warrior(string name, int lvl, int exp, int strength, int dexterity, int intelligence, int hp, int maxhp, int damage, int armor, int attackPerRound) : base(name, lvl, exp, strength, dexterity, intelligence, hp, maxhp, damage, armor)
		{
			this.AttacksPerRound = attackPerRound;
		}

		public Warrior(string name) : base(name)
		{
			Lvl = 1;
			Exp = 0;
			Strength = 15;
			Dexterity = 7;
			Intelligence = 4;
			Hp = 150;
			Maxhp = 150;
			Damage = 10;
			Armor = 20;
			AttacksPerRound = 2;
		}

		public override void LvlUp()
		{
			Lvl++;
			Strength += 5;
			Maxhp += 20;
			Armor += 3;
			Damage += 4;
		}
	}
}

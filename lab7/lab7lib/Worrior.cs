using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7lib
{
    class Worrior : Character
    {
		private int attacksPerRound;

		public int AttacksPerRound
		{
			get { return attacksPerRound; }
			set { attacksPerRound = value; }
		}


		public Worrior(string name, int lvl, int exp, int strength, int dexterity, int intelligence, int hp, int maxhp, int damage, int armor, int attackPerRound) : base(name, lvl, exp, strength, dexterity, intelligence, hp, maxhp, damage, armor)
		{
			this.AttacksPerRound = attackPerRound;
		}

		

	}
}

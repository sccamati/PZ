using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7lib
{
    class Wizzard : Character
    {
		private int mp_;

		public int Mp
		{
			get { return mp_; }
			set { mp_ = value; }
		}

		private int maxMp_;

		public int MaxMp
		{
			get { return mp_; }
			set { mp_ = value; }
		}

		public Wizzard(string name, int lvl, int exp, int strength, int dexterity, int intelligence, int hp, int maxhp, int damage, int armor, int mp, int mpMax) : base(name, lvl, exp, strength, dexterity, intelligence, hp, maxhp, damage, armor)
		{
			this.Mp = mp;
			this.MaxMp = MaxMp;
		}

	}
}

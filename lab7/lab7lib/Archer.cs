using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7lib
{
    class Archer : Character
    {
		private int chanceToDodge;

		public int ChanceToDodge
		{
			get { return chanceToDodge; }
			set { chanceToDodge = value; }
		}


		public Archer(string name, int lvl, int exp, int strength, int dexterity, int intelligence, int hp, int maxhp, int damage, int armor, int chanceToDodge) : base(name, 1, 0, 4, 10, 6, 20, 20, 10, 6)
		{
			this.ChanceToDodge = chanceToDodge;

		}
	}
}

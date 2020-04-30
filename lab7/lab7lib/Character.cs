using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7lib
{
    public class Character
    {

		private String name_;

		public String Name
		{
			get { return name_; }
			set { name_ = value; }
		}

		private int lvl_;

		public int Lvl
		{
			get { return lvl_; }
			set { lvl_ = value; }
		}

		private int exp_;

		public int Exp
		{
			get { return exp_; }
			set { exp_ = value; }
		}

		private int strength_;

		public int Strength
		{
			get { return strength_; }
			set { strength_ = value; }
		}

		private int dexterity_;

		public int Dexterity
		{
			get { return dexterity_; }
			set { dexterity_ = value; }
		}

		private int intelligence_;

		public int Intelligence
		{
			get { return intelligence_; }
			set { intelligence_ = value; }
		}

		private int hp_;

		public int Hp
		{
			get { return hp_; }
			set { hp_ = value; }
		}

		private int maxhp_;

		public int Maxhp
		{
			get { return maxhp_; }
			set { maxhp_ = value; }
		}

		private int damage_;

		public int Damage
		{
			get { return damage_; }
			set { damage_ = value; }
		}

		private int armor_;

		public int Armor
		{
			get { return armor_; }
			set { armor_ = value; }
		}

		public Character(string name, int lvl, int exp, int strength, int dexterity, int intelligence, int hp, int maxhp, int damage, int armor)
		{
			Name = name;
			Lvl = lvl;
			Exp = exp;
			Strength = strength;
			Dexterity = dexterity;
			Intelligence = intelligence;
			Hp = hp;
			Maxhp = maxhp;
			Damage = damage;
			Armor = armor;
		}


	}
}

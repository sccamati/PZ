using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7lib
{
	public abstract class Character : IComparable<Character>
	{
		private int damagePerRound;

		public virtual int DamagePerRound
		{
			get 
			{
				return Damage; 
			}
		}


		public String Name { get; set; }

		public int Lvl { get; set; }

		public int Exp { get; set; }

		public int Strength { get; set; }

		public int Dexterity { get; set; }

		public int Intelligence { get; set; }

		public int Hp { get; set; }

		public int Maxhp { get; set; }

		public int Damage { get; set; }

		public int Armor { get; set; }

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

		protected Character()
		{
		}

		public Character(string name)
		{
			Name = name;
		}

		public override string ToString()
		{
			return $"Name: {Name} Lvl: {Lvl} Exp: {Exp} Strength: {Strength} Dexterity: {Dexterity} Intelligence: {Intelligence} Hp: {Hp} Max HP {Maxhp} Damage: {Damage} Armor: {Armor}";
		}

		public void AddDamage(int damage)
		{
			Damage += damage;
		}

		public void AddArmor(int armor)
		{
			Armor += armor;
		}

		public virtual void TakeDamage(int damage)
		{
			if(damage - Armor/2 <= 0)
			{
				Hp -= 0;
			}
			else
			{
				Hp -= damage - Armor / 2;
			}
			
		}

		public abstract void LvlUp();

		
		public int CompareTo(Character character)
		{
			return Lvl.CompareTo(character.Lvl);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8lib
{
	public enum SpellType
	{
		Offensive,
		Deffensive,
		Healing,
	}
    public class Spell
    {
		private String name_;

		public String Name
		{
			get { return name_; }
			set { name_ = value; }
		}

		private SpellType type_;

		public SpellType Type
		{
			get { return type_; }
			set { type_ = value; }
		}

		private int manaCost_;

		public int ManaCost
		{
			get { return manaCost_; }
			set { manaCost_ = value; }
		}

		private int coolDown_;

		public int CoolDown
		{
			get { return coolDown_; }
			set { coolDown_ = value; }
		}

		private int effect_;

		public int Effect
		{
			get { return effect_; }
			set { effect_ = value; }
		}

		public override string ToString()
		{
			return $"Name: {Name} Type: {Type} Cost: {ManaCost} Cooldown: {CoolDown} Effect: {Effect}";
		}

		public override bool Equals(object obj)
		{
			return ToString() == obj.ToString();
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

	}
}

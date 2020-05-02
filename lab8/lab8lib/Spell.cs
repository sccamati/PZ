using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8lib
{
	public enum Type
	{
		Offensive,
		Defensive,
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

		private Type spellType_;

		public Type SpellType
		{
			get { return spellType_; }
			set { spellType_ = value; }
		}

		private int cost_;

		public int Cost
		{
			get { return cost_; }
			set { cost_ = value; }
		}

		private int cooldown_;

		public int Cooldown
		{
			get { return cooldown_; }
			set { cooldown_ = value; }
		}

		private int effect_;

		public int Effect
		{
			get { return effect_; }
			set { effect_ = value; }
		}

		

	}
}

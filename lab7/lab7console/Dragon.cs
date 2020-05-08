using lab7lib;
using lab7lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7console

{

    public delegate void DragonDelegate(int value);

    public partial class Dragon : Character, IMagic
    {
        public event DragonDelegate OnFireBreathed;


        public int MaxMP { get; set; }
        public int CurrentMP { get ; set; }
        partial void OnFireBreathedPartial(int damage);

        public int CastSpell(int MP)
        {
           return FireBreath();
        }

        public override void LvlUp()
        {
            this.Lvl +=1;
        }

        public int FireBreath()
        {
            int damage = (Lvl * Intelligence) / 10;
            Console.WriteLine($"Dragon {Name}  breathes fire and deals {damage} ");
            OnFireBreathed?.Invoke(damage);
            OnFireBreathedPartial(damage);
            return damage;
        }
    }
}

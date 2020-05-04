using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8lib
{
    public class SpellBook : List<Spell>
    {
        public override string ToString()
        {
            String spells = "";
            foreach (var item in this)
            {
                spells += item.ToString() + "\n";
                
            }
            return spells;
        }
    }
}

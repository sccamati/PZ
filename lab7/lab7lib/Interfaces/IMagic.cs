using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7lib.Interfaces
{
    public interface IMagic
    {
        int CastSpell(int MP);
        int MaxMP { get; set; }
        int CurrentMP { get; set; }
    }
}

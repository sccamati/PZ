using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.klasy
{
    public class SumaComparer : IComparer<Czlowiek>
    {

        public int Compare(Czlowiek x, Czlowiek y)
        {
            return x.Zamoznosc.CompareTo(y.Zamoznosc);
        }

    }
}

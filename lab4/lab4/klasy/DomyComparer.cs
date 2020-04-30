using lab4.klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class DomyComparer : IComparer<Czlowiek>
    {

        public int Compare(Czlowiek x, Czlowiek y)
        {
            return x.Domy.Count.CompareTo(y.Domy.Count);
        }
    }
}

using lab4.klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class SamochodComparer : IComparer<Czlowiek>
    {
        

        public int Compare(Czlowiek x, Czlowiek y)
        {
            Czlowiek pr1 = (Czlowiek)x;
            Czlowiek pr2 = (Czlowiek)y;
            int cars1 = pr1.Samochody.Count;
            int cars2 = pr2.Samochody.Count;
            if (cars1 > cars2)
            {
                return 1;
            }

            if (cars1 < cars2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

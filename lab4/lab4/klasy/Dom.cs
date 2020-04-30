using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.klasy
{
    public class Dom
    {
        public int Cena { get; set; }
        public int Powierzchnia { get; set; }

        public Dom(int cena, int powierzchnia)
        {
            Cena = cena;
            Powierzchnia = powierzchnia;
        }

        public override string ToString()
        {
            return $"Cena: {Cena} Powierzchnia: {Powierzchnia}";
        }
    }
}

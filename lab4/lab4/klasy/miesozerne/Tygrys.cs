using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4lib.interfejsy;

namespace lab4lib.klasy.miesozerne
{
    public class Tygrys : Zwierze, IMiesozerne
    {
        public Tygrys(int szybkosc, string imie, int wysokosc) : base(szybkosc, imie, wysokosc)
        {
        }

        public void ZjedzMieso()
        {
            Console.WriteLine("Tygrys zjada jakies zwierzatko");
        }

        public void ZnajdzPozywienie()
        {
            Console.WriteLine("Tygrys szuka zwierzatka do jedzenia");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

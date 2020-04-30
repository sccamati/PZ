using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4lib.interfejsy;

namespace lab4lib.klasy.wszystkozerne
{
    public class Jenot : Zwierze, IMiesozerne, IRoslinozerne
    {
        public Jenot(int szybkosc, string imie, int wysokosc) : base(szybkosc, imie, wysokosc)
        {
        }

        public void ZjedzMieso()
        {
            Console.WriteLine("Jem mieso");
        }

        public void ZjedzRosline()
        {
            Console.WriteLine("Jem rosline");
        }

        void IRoslinozerne.ZnajdzPozywienie()
        {
            Console.WriteLine("Szukam jakiegos liscia");
        }

        void IMiesozerne.ZnajdzPozywienie()
        {
            Console.WriteLine("Jenot znalazl jakies miesko");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

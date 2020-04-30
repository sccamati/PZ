using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4lib.interfejsy;

namespace lab4lib.klasy.miesozerne
{
    public class Rosiczka : Roslina, IMiesozerne
    {
        

        public void ZjedzMieso()
        {
            Console.WriteLine("Rosiczka Wsuwam muche");
        }

        public void ZnajdzPozywienie()
        {
            Console.WriteLine("Rosiczka czeka na muche ");
        }

        public Rosiczka(int iloscPowietrza, string imie, int wysokosc, Stan stan) : base(iloscPowietrza, imie, wysokosc, stan)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

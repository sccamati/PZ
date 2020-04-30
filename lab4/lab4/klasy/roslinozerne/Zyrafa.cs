using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4lib.interfejsy;

namespace lab4lib.klasy.roslinozerne
{
    public class Zyrafa : Zwierze, IRosnace, IRoslinozerne
    {
        public Zyrafa(int szybkosc, string imie, int wysokosc) : base(szybkosc, imie, wysokosc)
        {
        }

        public void ZjedzRosline()
        {
            Console.WriteLine( "Zyrafa wsuwa Roslinke");
        }

        public void ZnajdzPozywienie()
        {
            Console.WriteLine("Zyrafa szuka roslinki");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

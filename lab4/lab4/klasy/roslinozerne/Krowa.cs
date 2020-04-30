using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4lib.interfejsy;


namespace lab4lib.klasy.roslinozerne
{
    public class Krowa : Zwierze, IRoslinozerne
    {
        public Krowa(int szybkosc, string imie, int wysokosc) : base(szybkosc, imie, wysokosc)
        {
        }

        public void ZjedzRosline()
        {
            Console.WriteLine("Krowa wsuwa trawe az sie jej uszy trzesa");
        }
        
        public void ZnajdzPozywienie()
        {
            Console.WriteLine("Krowa znajduje trawe");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

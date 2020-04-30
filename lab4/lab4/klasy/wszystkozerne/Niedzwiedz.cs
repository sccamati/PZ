using lab4lib.interfejsy;
using System;

namespace lab4lib.klasy.wszystkozerne
{
    public class Niedzwiedz : Zwierze, IMiesozerne, IRoslinozerne
    {
        public Niedzwiedz(int szybkosc, string imie, int wysokosc) : base(szybkosc, imie, wysokosc)
        {
        }

        public void ZjedzMieso()
        {
            Console.WriteLine("Niedzwiedz wsuwa miecho");
        }

        public void ZjedzRosline()
        {
            Console.WriteLine("Niedzwiedz wsuwa roslinke");
        }

         void IRoslinozerne.ZnajdzPozywienie()
        {
            Console.WriteLine("Niedzwiedz szuka czegos do schrupania jakis lisc cos tam");
        }

         void IMiesozerne.ZnajdzPozywienie()
        {
            Console.WriteLine("Niedzwiedz szuka czegos do schrupania jakies miesko dobre");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
using System;

namespace lab4lib.klasy
{
    public abstract class Istota
    {
        public String Imie { get; set; }
        public int Wysokosc { get; set; }

        public Istota(string imie, int wysokosc)
        {
            Imie = imie;
            Wysokosc = wysokosc;
        }

        public override string ToString()
        {
            return $"Imie: {Imie} Wysokosc: {Wysokosc}";
        }
    }
}
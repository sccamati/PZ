using lab4lib.interfejsy;
using lab4lib.wyjatki;
using System;

namespace lab4lib.klasy
{
    public class Zwierze : Istota, IRosnace, ICloneable
    {
        private int szybkosc;

        public int Szybkosc
        {
            get
            {
               
                return szybkosc;
            }

            set {
                if (value > 1225)
                {
                    throw new SzybkoscException($"Szybkosc nie moze byc wieksza niz predkosc. Podana szybosc:{Szybkosc}");
                }
                else
                {
                    szybkosc = value;
                }
                 }
        }

        public Zwierze(int szybkosc, string imie, int wysokosc) : base(imie, wysokosc)
        {
            this.Szybkosc = szybkosc;
        }

        public void Rosnij()
        {
            Wysokosc = Wysokosc + Wysokosc / 100;
        }

        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return base.ToString() + $"Szybkosc:{Szybkosc}";
        }
    }
}
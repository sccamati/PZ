using lab4lib.wyjatki;
using System;

namespace lab4lib.klasy
{
    public class Duch : Istota
    {
        public int IloscEktoplazmy { get; set; }
        public String Straszenie { get; set; }

        private int przezroczystosc;

        public int Przezroczystosc
        {
            get
            { return przezroczystosc; }
            set {
                if (value < 0 || value > 100)
                {
                    throw new PrzezroczystoscException($"Przezroczystosc musi byc w przedziale od 0 do 100. Podana przezroczystosc {przezroczystosc}");
                }
                else
                {
                    przezroczystosc = value;
                }
                }
        }

 

        public Duch(int Przezroczystosc, int IloscEktoplazmy, string Straszenie, string imie, int wysokosc) : base(imie, wysokosc)
        {
            this.Przezroczystosc = Przezroczystosc;
            this.IloscEktoplazmy = IloscEktoplazmy;
            this.Straszenie = Straszenie;
        }

        public override string ToString()
        {
            return base.ToString() + $" ilosc ektoplazmy:{IloscEktoplazmy} straszenie:{Straszenie} przezroczystosc:{Przezroczystosc}";
        }
    }
}
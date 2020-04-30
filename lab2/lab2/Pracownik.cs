using System;

namespace lab2
{
    internal abstract class Pracownik
    {
        protected Pracownik()
        {
        }

        protected Pracownik(int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, decimal pensja)
        {
            Numer_Identyfikacyjny = numerIdentyfikacyjny;
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Pensja = pensja;
        }

        private int _numerIdentyfikacyjny;
        private String _imie;
        private String _nazwisko;
        private int _wiek;
        private decimal _pensja;

        #region MyRegion

        public int Numer_Identyfikacyjny
        {
            get { return _numerIdentyfikacyjny; }
            set { _numerIdentyfikacyjny = value; }
        }

        public String Imie
        {
            get { return _imie; }
            set { _imie = value; }
        }

        public String Nazwisko
        {
            get { return _nazwisko; }
            set { _nazwisko = value; }
        }

        public int Wiek
        {
            get { return _wiek; }
            set { _wiek = value; }
        }

        public decimal Pensja
        {
            get { return _pensja; }
            set { _pensja = value; }
        }

        #endregion MyRegion

        public virtual void Wyswietl()
        {
            Console.Write("\n" + "ID " + Numer_Identyfikacyjny + " Imie " + Imie + " Nazwisko " + Nazwisko + " Wiek " + Wiek + " Pensja " + Pensja);
        }

        public virtual void ZwiekszPensje(decimal pieniadze)
        {
            Pensja += pieniadze;
        }
    }
}
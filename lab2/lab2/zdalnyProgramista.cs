namespace lab2
{
    internal class zdalnyProgramista : Programista
    {
        private int odleglosc;

        public int Odleglosc
        {
            get { return odleglosc; }
            set { odleglosc = value; }
        }

        public zdalnyProgramista(int odleglosc, int liczba_Wykorzystywanych_Technologii, int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, decimal pensja) : base( liczba_Wykorzystywanych_Technologii,  numerIdentyfikacyjny,  imie,  nazwisko,  wiek,  pensja)
        {
            Odleglosc = odleglosc;
        }

        public zdalnyProgramista()
        {
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            System.Console.Write(" odleglosc " + odleglosc + "\n");
        }

        public override void ZwiekszPensje(decimal pieniadze)
        {
            base.ZwiekszPensje(pieniadze);
        }
    }
}   
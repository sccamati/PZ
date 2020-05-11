namespace lab2
{
    public class ZdalnyProgramista : Programista
    {
        private int odleglosc;

        public int Odleglosc
        {
            get { return odleglosc; }
            set { odleglosc = value; }
        }

        public ZdalnyProgramista(int odleglosc, int liczba_Wykorzystywanych_Technologii, int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, decimal pensja) : base(liczba_Wykorzystywanych_Technologii, numerIdentyfikacyjny, imie, nazwisko, wiek, pensja)
        {
            Odleglosc = odleglosc;
        }

        public ZdalnyProgramista()
        {
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            System.Console.Write($" odleglosc {odleglosc}");
        }

        public override void ZwiekszPensje(decimal pieniadze)
        {
            base.ZwiekszPensje(pieniadze * Odleglosc);
        }
    }
}
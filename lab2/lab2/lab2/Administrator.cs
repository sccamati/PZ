namespace lab2
{
    public class Administrator : Pracownik
    {
      

        private int liczbaSerwerow;

        public int Liczba_Serwerow
        {
            get { return liczbaSerwerow; }
            set { liczbaSerwerow = value; }
        }

        public Administrator(int liczba_Serwerow, int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, decimal pensja) :base (numerIdentyfikacyjny, imie, nazwisko, wiek, pensja)
        {
            this.Liczba_Serwerow = liczba_Serwerow;
        }

        public Administrator()
        {
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            System.Console.Write($" Liczba serwerow {Liczba_Serwerow}\n");
        }

        public override void ZwiekszPensje(decimal pieniadze)
        {
            base.ZwiekszPensje(pieniadze * Liczba_Serwerow);
        }
    }
}
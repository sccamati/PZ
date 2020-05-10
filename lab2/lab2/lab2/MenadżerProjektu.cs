namespace lab2
{
    internal class MenadżerProjektu : Pracownik
    {
        private int liczbaProjektow;

        public int Liczba_Projektow
        {
            get { return liczbaProjektow; }
            set { liczbaProjektow = value; }
        }

        public MenadżerProjektu(int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, decimal pensja, int liczba_Projektow) : base(numerIdentyfikacyjny, imie, nazwisko, wiek, pensja)
        {
            this.Liczba_Projektow = liczba_Projektow;
        }

        public MenadżerProjektu(int v)
        {
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            System.Console.Write($" liczba projektow  {Liczba_Projektow}\n");
        }

        public override void ZwiekszPensje(decimal pieniadze)
        {
            base.ZwiekszPensje(pieniadze * Liczba_Projektow);
        }
    }
}
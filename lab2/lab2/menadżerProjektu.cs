namespace lab2
{
    internal class menadżerProjektu : Pracownik
    {
        private int liczbaProjektow;

        public int Liczba_Projektow
        {
            get { return liczbaProjektow; }
            set { liczbaProjektow = value; }
        }

        public menadżerProjektu(int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, decimal pensja, int liczba_Projektow) : base(numerIdentyfikacyjny, imie, nazwisko, wiek, pensja)
        {
            this.Liczba_Projektow = liczba_Projektow;
        }

        public menadżerProjektu(int v)
        {
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            System.Console.Write(" liczba projektow " + Liczba_Projektow + "\n");
        }

        public override void ZwiekszPensje(decimal pieniadze)
        {
            base.ZwiekszPensje(pieniadze);
        }
    }
}
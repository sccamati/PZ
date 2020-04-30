namespace ClassLibrary
{
    public class Tom : Ksiazka
    {
        public int NumerTomu { get; set; }
        public int LiczbaTomow { get; set; }

        public Tom(int numerTomu, int liczbaTomow, string autor, string isbn, string tytul, int rokWydania, int liczbaStron)
            : base(autor, isbn, tytul, rokWydania, liczbaStron)
        {
            NumerTomu = numerTomu;
            LiczbaTomow = liczbaTomow;
        }

        public Tom()
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"Numer Tomu: {NumerTomu} Liczba tomow: {LiczbaTomow}";
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return ToString() == obj.ToString();
        }
    }
}
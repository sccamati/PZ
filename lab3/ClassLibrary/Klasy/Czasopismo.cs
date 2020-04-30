namespace ClassLibrary
{
    public enum Czestotliwosc
    {
        Dziennik,
        Tygodnik,
        Miesiecznik,
        Rocznik
    }
    public class Czasopismo : Dokument
    {
        public int Numer { get; set; }

        public Czestotliwosc Rodzaj { get; set; }

 

        public Czasopismo(int numer, string isbn, string tytul, int rokWydania, int liczbaStron, Czestotliwosc czestotliwosc)
            : base(isbn, tytul, rokWydania, liczbaStron)
        {
            Numer = numer;
            Rodzaj = czestotliwosc;
        }

        public Czasopismo()
        {
           
        }

       

        public override string ToString()
        {
            return base.ToString() + $"Numer: {Numer}";
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
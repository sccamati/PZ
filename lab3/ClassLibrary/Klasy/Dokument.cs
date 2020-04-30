using System;

namespace ClassLibrary
{
    public abstract class Dokument
    {
        public String Isbn { get; set; }
        public String Tytul { get; set; }
        public int RokWydania { get; set; }
        public int LiczbaStron { get; set; }

        public Dokument(string isbn, string tytul, int rokWydania, int liczbaStron)
        {
            Isbn = isbn;
            Tytul = tytul;
            RokWydania = rokWydania;
            LiczbaStron = liczbaStron;
        }

        public Dokument()
        {
        }

        public override string ToString()
        {
            return $"ISBN {Isbn} Tytul {Tytul} Rok wydania {RokWydania} Liczba Stron {LiczbaStron}";
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
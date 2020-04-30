using System;

namespace ClassLibrary
{
    public class Ksiazka : Dokument
    {
        public String Autor { get; set; }

        public Ksiazka(string autor, string isbn, string tytul, int rokWydania, int liczbaStron)
            : base(isbn, tytul, rokWydania, liczbaStron)
        {
            Autor = autor;
        }

        public Ksiazka()
        {
        }

        public override string ToString()
        {
            return base.ToString() + $" Autor {Autor}";
        }

        public override bool Equals(object obj)
        {
            return ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
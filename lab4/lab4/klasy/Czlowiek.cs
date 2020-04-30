using lab4lib.klasy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lab4.klasy
{
    public class Czlowiek : Zwierze, IEnumerable, IComparable<Czlowiek>
    {
        public int IQ { get; set; }
        public List<Samochod> Samochody { get; set; }
        public List<Dom> Domy { get; set; }

        

        public int Zamoznosc
        {
            get 
            {
                return Domy.Sum(d => d.Cena) + Samochody.Sum(s => s.Cena); 
            }
        }



        public Czlowiek(int iQ,  int szybkosc, string imie, int wysokosc, List<Dom> domy, List<Samochod> samochody) : base(szybkosc, imie, wysokosc)
        {
            IQ = iQ;
            Samochody = samochody;
            Domy = domy;
        }

         IEnumerator IEnumerable.GetEnumerator()
        {
            return Samochody.GetEnumerator();
        }

        public IEnumerable PrzegldajDomy(int cena = 0)
        {
            
            foreach (var dom in Domy)
            {
                if(cena > dom.Cena)
                {
                    yield return dom;
                }
            }
           
        }

        public override object Clone()
        {
            Czlowiek czlowiek = (Czlowiek)this.MemberwiseClone();
            czlowiek.Domy = new List<Dom>();
            foreach (var item in this.Domy)
            {
                czlowiek.Domy.Add(new Dom(item.Cena, item.Powierzchnia));
            }

            czlowiek.Samochody = new List<Samochod>();
            foreach (var item in this.Samochody)
            {
                czlowiek.Samochody.Add(new Samochod(item.Model, item.Cena));
            }


            return czlowiek;
        }



        public int Compare(IComparer<Czlowiek> comparer, Czlowiek x, Czlowiek y)
        {
            return comparer.Compare(x, y);
        }

        public override string ToString()
        {
            return base.ToString() + $" IQ:{IQ} Samochody{Samochody} Domy{Domy}";
        }

        public int CompareTo(Czlowiek other)
        {
            return other.IQ.CompareTo(this.IQ);
        }
    }
}
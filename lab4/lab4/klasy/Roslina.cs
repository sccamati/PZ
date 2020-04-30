using lab4lib.interfejsy;

namespace lab4lib.klasy
{
    public enum Stan
    {
        Rosnie,
        Zakwitla,
        Zaowocowala
    }

    public class Roslina : Istota, IRosnace, IRoslinowate
    {
        public int IloscPowietrza { get; set; }
        public Stan Stan { get; set; }

        public Roslina(int iloscPowietrza, string imie, int wysokosc, Stan stan) : base(imie, wysokosc)
        {
            this.IloscPowietrza = iloscPowietrza;
            this.Stan = stan;
        }

        public void Rosnij()
        {
            Wysokosc = Wysokosc + IloscPowietrza / 10;
        }

        void IRoslinowate.Rosnij()
        {
            Wysokosc = Wysokosc + IloscPowietrza / 10;
        }

        public void Zakwitnij()
        {
            Stan = Stan.Zakwitla;
        }

        public void Owocuj()
        {
            Stan = Stan.Zaowocowala;
        }

        public override string ToString()
        {
            return base.ToString() + $" ilosc powietrza:{IloscPowietrza} Stan:{Stan}";
        }
    }
}
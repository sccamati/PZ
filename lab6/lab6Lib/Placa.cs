using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6Lib
{
    public static class Placa
    {
        public static void ZwiekszPlaceS(Pracownik pracownik) {
            
            if(pracownik.LiczbaSprzedazy > 10)
            {
                Console.WriteLine($"Zmieniono pensje u pracownika {pracownik.Imie} {pracownik.Nazwisko} z {pracownik.Pensja} na {pracownik.Pensja + 200}");
                pracownik.Pensja += 200;

            }
        }

        public static void ZwiekszPlaceP (Pracownik pracownik)
        {
            if(pracownik.Staz > 2)
            {
                Console.WriteLine($"Zmieniono pensje u pracownika {pracownik.Imie} {pracownik.Nazwisko} z {pracownik.Pensja} na");
                pracownik.Pensja += pracownik.Pensja * (decimal)0.1;
                Console.Write($"{pracownik.Pensja}");
            }
        }

        public static void ZerujSprzedaz (Pracownik pracownik)
        {
            Console.WriteLine($"Zmieniono liczbe sprzedazy u pracownika {pracownik.Imie} {pracownik.Nazwisko} z {pracownik.LiczbaSprzedazy} na 0");
            pracownik.LiczbaSprzedazy = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab6Lib;

namespace lab6console
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma firma = new Firma();

            Pracownik pracownik = new Pracownik(2, "Marcin", "Kowalski", 1, 12, 2100);
            Pracownik pracownik2 = new Pracownik(4, "Piotr", "Kowalski", 3, 8, 2200);
            Pracownik pracownik3 = new Pracownik(3, "Marek", "Nowak", 4, 20, 2300);
            Pracownik pracownik4 = new Pracownik(1, "Piotr", "Kowalski", 10, 50, 3200);

            firma.OnAdded += AddedMessage;
            firma.OnDelete += DeleteMessage;

            firma.Add(pracownik);
            firma.Add(pracownik2);
            firma.Add(pracownik3);
            firma.Add(pracownik4);
            firma.Delete(1);

            Console.WriteLine("Info");
            firma.EmployeeInfo(e => $"ID {e.ID} zarabia {e.Pensja}");
            Console.WriteLine("Search");
            firma.SearchEmployees(e => e.ID > 2).ForEach(e => Console.WriteLine(e.ToString()));
            firma.Sort((prac1, prac2) => prac1.ID.CompareTo(prac2.ID));
            Console.WriteLine("Po sortowaniu");
            firma.EmployeeInfo(e => $"ID {e.ID} zarabia {e.Pensja}");

        }

        private static void DeleteMessage(Pracownik pracownik)
        {
            Console.WriteLine($"Usunieto pracownika {pracownik.Imie}");
        }



        private static void AddedMessage(Pracownik pracownik)
        {
            Console.WriteLine($"Dodano Pracownika: {pracownik.Imie}");
        }
    }
}

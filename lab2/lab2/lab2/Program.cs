using System.Collections.Generic;
using System;
namespace lab2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pom = null;
            String pensja;
            List<Pracownik> pracownicy = new List<Pracownik>();
            MenadżerProjektu menadżerProjektu = new MenadżerProjektu(1, "Piotr", "Kowalski", 30, 1600, 2);
            Administrator administrator = new Administrator(2, 2, "Jan", "Polak", 34, 1700);
            Programista programista = new Programista(4, 3, "Kamil", "Dobry", 27, 1800);
            ZdalnyProgramista zdalnyProgramista = new ZdalnyProgramista(1000, 6, 4, "Tomek", "Dobry", 32, 1900);
            pracownicy.Add(menadżerProjektu);
            pracownicy.Add(administrator);
            pracownicy.Add(programista);
            pracownicy.Add(zdalnyProgramista);
            
            while (pom != "0")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\n 1. wyswietl wszystkich pracownikow \n 2. Wyswietl pracownikow na wybranym stanowisku \n 3. Zwiekszenie pensji wybranego pracownika \n 4. Zwiekszenie pensji dla pracownikow na wybranym stanowisku \n 5. Zwiekszenie pensji dla wszystkich pracownikow \n 6. Wyswietl statystyki dotyczace pensji");
                Console.ForegroundColor = ConsoleColor.White;
                pom = Console.ReadLine();
                switch (pom)
                {
                    case "1":
                        WyswietlAll(pracownicy);
                        break;
                    case "2":
                        Wyswietl(pracownicy);
                        break;
                    case "3":
                        ZwiekszPensjeID(pracownicy);
                        break;

                    case "4":
                        ZwiekszPensjeStanowisko(pracownicy);
                        break;

                    case "5":
                        ZwiekszPensjeWszystkik(pracownicy);
                        break;

                    case "6":
                        ObliczMR(pracownicy);
                        break;

                    default:
                        Console.WriteLine("Wybierz jeszcze raz");
                        break;
                }
            }



        }

        private static void WyswietlAll(List<Pracownik> pracownicy)
        {
            Console.Clear();
            foreach (Pracownik pracownik in pracownicy)
            {
                pracownik.Wyswietl();
            }
        }

        private static void ZwiekszPensjeWszystkik(List<Pracownik> pracownicy)
        {
            Console.Clear();
            Console.WriteLine("Podaj liczbe o jaka ma byc zwiekszona pensja");
            String pensja = Console.ReadLine();
            foreach (Pracownik pracownik in pracownicy)
            {

                pracownik.ZwiekszPensje(Convert.ToDecimal(pensja));

            }
        }

        private static void ZwiekszPensjeID(List<Pracownik> pracownicy)
        {
            Console.WriteLine("\n Wpisz ID pracownika ktorego pensje chcesz zwiekszyc \n ");
            String id = Console.ReadLine();

            foreach (Pracownik pracownik in pracownicy)
            {
                if (id.Equals(pracownik.Numer_Identyfikacyjny))
                {
                    Console.WriteLine("\n O ile zwiekszyc pensje \n ");
                    String pensja = Console.ReadLine();
                    pracownik.ZwiekszPensje(Convert.ToDecimal(pensja));
                }

            }
        }

        private static void ZwiekszPensjeStanowisko(List<Pracownik> pracownicy)
        {
            Console.Clear();
            Console.WriteLine("\n 1. zwieksz pensje wszystkich Administratorow \n 2. zwieksz pensje wszystkich menadzerow projektu\n 3. zwieksz pensje wszystkich Programistow\n 4. zwieksz pensje wszystkich zdalnych programistow\n");
            String pom2 = Console.ReadLine();
            Console.WriteLine("Podaj liczbe o jaka ma byc zwiekszona pensja");
            String pensja = Console.ReadLine();
            switch (pom2)
            {
                case "1":
                    foreach (Pracownik pracownik in pracownicy)
                    {
                        if (pracownik.GetType() == typeof(Administrator))
                        {
                            pracownik.ZwiekszPensje(Convert.ToDecimal(pensja));
                        }

                    }
                    break;
                case "2":
                    foreach (Pracownik pracownik in pracownicy)
                    {
                        if (pracownik.GetType() == typeof(MenadżerProjektu))
                        {
                            pracownik.ZwiekszPensje(Convert.ToDecimal(pensja));
                        }

                    }
                    break;
                case "3":
                    foreach (Pracownik pracownik in pracownicy)
                    {
                        if (pracownik.GetType() == typeof(Programista))
                        {
                            pracownik.ZwiekszPensje(Convert.ToDecimal(pensja));
                        }

                    }
                    break;
                case "4":
                    foreach (Pracownik pracownik in pracownicy)
                    {
                        if (pracownik.GetType() == typeof(ZdalnyProgramista))
                        {
                            pracownik.ZwiekszPensje(Convert.ToDecimal(pensja));
                        }

                    }
                    break;
                default:
                    Console.WriteLine("Wybierz jeszcze raz");
                    break;
            }
        }

        private static void Wyswietl(List<Pracownik> pracownicy)
        {
            Console.Clear();
            Console.WriteLine("\n 1. wyswietl wszystkich Administratorow \n 2. Wyswietl wszystkich menadzerow projektu\n 3. Wyswietl wszystkich Programistow\n 4. Wyswietl wszystkich zdalnych programistow\n");
            String pom2 = Console.ReadLine();
            switch (pom2)
            {
                case "1":
                    foreach (Pracownik pracownik in pracownicy)
                    {
                        if (pracownik.GetType() == typeof(Administrator))
                        {
                            pracownik.Wyswietl();
                        }

                    }
                    break;
                case "2":
                    foreach (Pracownik pracownik in pracownicy)
                    {
                        if (pracownik.GetType() == typeof(MenadżerProjektu))
                        {
                            pracownik.Wyswietl();
                        }

                    }
                    break;
                case "3":
                    foreach (Pracownik pracownik in pracownicy)
                    {
                        if (pracownik.GetType() == typeof(Programista))
                        {
                            pracownik.Wyswietl();
                        }

                    }
                    break;
                case "4":
                    foreach (Pracownik pracownik in pracownicy)
                    {
                        if (pracownik.GetType() == typeof(ZdalnyProgramista))
                        {
                            pracownik.Wyswietl();
                        }

                    }
                    break;
                default:
                    Console.WriteLine("Wybierz jeszcze raz");
                    break;
            }
        }

        private static void ObliczMR(List<Pracownik> pracownicy)
        {
            Console.Clear();
            decimal pensjaWszystkich = 0;
            decimal pensjaAdmin = 0;
            decimal pensjaMenadzer = 0;
            decimal pensjaProgram = 0;
            decimal pensjaZdalny = 0;

            foreach (Pracownik pracownik in pracownicy)
            {
                pensjaWszystkich += pracownik.Pensja;

                if (pracownik.GetType() == typeof(Administrator))
                {
                    pensjaAdmin += pracownik.Pensja;
                }

                if (pracownik.GetType() == typeof(MenadżerProjektu))
                {
                    pensjaMenadzer += pracownik.Pensja;
                }

                if (pracownik.GetType() == typeof(Programista))
                {
                    pensjaProgram += pracownik.Pensja;
                }

                if (pracownik.GetType() == typeof(ZdalnyProgramista))
                {
                    pensjaZdalny += pracownik.Pensja;
                }
            }

            Console.WriteLine("Stanowisko     Miesiecznie   Rocznie");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Administator      {pensjaAdmin}        {pensjaAdmin * 12}");
            Console.WriteLine($"Menadzer          {pensjaMenadzer}        {pensjaAdmin * 12}");
            Console.WriteLine($"Programista       {pensjaProgram}        {pensjaProgram * 12}");
            Console.WriteLine($"Zdalny            {pensjaZdalny}        {pensjaAdmin * 12}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Razem             {pensjaWszystkich}        {pensjaWszystkich * 12}");
        }
    }
}

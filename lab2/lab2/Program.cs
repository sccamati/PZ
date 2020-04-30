using System.Collections.Generic;
using System;
namespace lab2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pom = null;
            string pom2 = null;
            List<Pracownik> pracownicy = new List<Pracownik>();
            menadżerProjektu menadżerProjektu = new menadżerProjektu(1, "Piotr", "Kowalski", 30, 1600, 2);
            Administrator administrator = new Administrator(2, 2, "Jan", "Polak", 34, 1700);
            Programista programista = new Programista(4, 3, "Kamil", "Dobry", 27, 1800);
            zdalnyProgramista zdalnyProgramista = new zdalnyProgramista(1000, 6, 4, "Tomek", "Dobry", 32, 1900);
            #region MyRegion

            #endregion
            pracownicy.Add(menadżerProjektu);
            pracownicy.Add(administrator);
            pracownicy.Add(programista);
            pracownicy.Add(zdalnyProgramista);
            
            while (pom != "0")
            {
                Console.WriteLine("\n 1. wyswietl wszystkich pracownikow \n 2. Wyswietl pracownikow na wybranym stanowisku \n 3. Zwiekszenie pensji wybranego pracownika \n 4. Zwiekszenie pensji dla pracownikow na wybranym stanowisku");
                pom = Console.ReadLine();
                switch (pom)
                {
                    case "1":
                        foreach (Pracownik pracownik in pracownicy)
                        {
                            pracownik.Wyswietl();
                        }
                        break;
                    case "2":
                        Console.WriteLine("\n 1. wyswietl wszystkich Administratorow \n 2. Wyswietl wszystkich menadzerow projektu\n 3. Wyswietl wszystkich Programistow\n 4. Wyswietl wszystkich zdalnych programistow\n");
                        pom2 = Console.ReadLine();
                        switch (pom2)
                        {
                            case "1":
                                foreach (Pracownik pracownik in pracownicy)
                                {
                                    if(pracownik.GetType() == typeof(Administrator))
                                    {
                                        pracownik.Wyswietl();
                                    }
                                    
                                }
                                break;
                            case "2":
                                foreach (Pracownik pracownik in pracownicy)
                                {
                                    if (pracownik.GetType() == typeof(menadżerProjektu))
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
                                    if (pracownik.GetType() == typeof(zdalnyProgramista))
                                    {
                                        pracownik.Wyswietl();
                                    }

                                }
                                break;
                            default:
                                Console.WriteLine("Wybierz jeszcze raz");
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n Wpisz ID pracownika ktorego pensje chcesz zwiekszyc \n ");
                        String id =  Console.ReadLine();
                      
                        foreach (Pracownik pracownik in pracownicy)
                        {
                            if(id.Equals(pracownik.Numer_Identyfikacyjny))
                            {
                                Console.WriteLine("\n O ile zwiekszyc pensje \n ");
                                String pensja = Console.ReadLine();
                                pracownik.ZwiekszPensje(Convert.ToDecimal(pensja));
                            }
                            
                        }
                        break;

                    case "4":
                        Console.WriteLine("\n 1. wyswietl wszystkich Administratorow \n 2. Wyswietl wszystkich menadzerow projektu\n 3. Wyswietl wszystkich Programistow\n 4. Wyswietl wszystkich zdalnych programistow\n");
                        pom2 = Console.ReadLine();
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
                                    if (pracownik.GetType() == typeof(menadżerProjektu))
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
                                    if (pracownik.GetType() == typeof(zdalnyProgramista))
                                    {
                                        pracownik.Wyswietl();
                                    }

                                }
                                break;
                            default:
                                Console.WriteLine("Wybierz jeszcze raz");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Wybierz jeszcze raz");
                        break;
                }
            }

        }
        }
    }

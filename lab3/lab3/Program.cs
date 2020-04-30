using ClassLibrary;
using ClassLibrary.Wyjatki;
using System;
using System.Collections.Generic;

namespace lab3app
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Zarzadzanie dokuments = new Zarzadzanie();
            Czasopismo czasopismo = new Czasopismo(1, "1", "Jakis", 1992, 30, Czestotliwosc.Miesiecznik);
            Czasopismo czasopismo2 = new Czasopismo(2, "2", "Cos", 1994, 25, Czestotliwosc.Rocznik);
            Czasopismo czasopismo3 = new Czasopismo(3, "3", "Tak", 2012, 45, Czestotliwosc.Miesiecznik);
            Ksiazka ksiazka = new Ksiazka("Andrzej", "4", "Daleko", 1923, 300);
            Ksiazka ksiazka2 = new Ksiazka("Patryk", "5", "Blisko", 2003, 260);
            Ksiazka ksiazka3 = new Ksiazka("Alicja", "6", "Uwazaj", 2013, 476);
            Tom tom = new Tom(2, 2, "Adam", "7", "Siema", 2004, 240);
            Tom tom2 = new Tom(1, 2, "Adam", "8", "Siema", 2001, 680);
            Tom tom3 = new Tom(1, 3, "Jola", "9", "Ktory", 1670, 1250);
            dokuments.Dodaj(czasopismo);
            dokuments.Dodaj(czasopismo2);
            dokuments.Dodaj(czasopismo3);
            dokuments.Dodaj(ksiazka);
            dokuments.Dodaj(ksiazka2);
            dokuments.Dodaj(ksiazka3);
            dokuments.Dodaj(tom);
            dokuments.Dodaj(tom2);
            dokuments.Dodaj(tom3);

            foreach (Dokument dokument in dokuments.dokumenty)
            {

                Console.WriteLine(dokument.ToString()); 
            }

            Console.WriteLine("Czasopisma o czestotliwości Miesiecznik");
            foreach (var dok in dokuments.PobierzCzasopisma(Czestotliwosc.Miesiecznik))
            {
            
                Console.WriteLine(dok.Tytul);
            }
            Console.WriteLine("Tomy o tytule siema");
            foreach (var dok in dokuments.PobierzTomy("Siema"))
            {
                Console.WriteLine(dok.Tytul);
            }
            Console.WriteLine("Dokument o nazwie Tak");
            foreach (var dok in dokuments.PobierzDokumenty("Tak"))
            {
                Console.WriteLine(dok.Tytul);
            }

            Console.WriteLine("Usuwanie po Isbn numer 2");
            dokuments.UsunPoIsbn("2");

            foreach (Dokument dokument in dokuments.dokumenty)
            {
                if (dokument is Tom)
                {
                    Tom tom1 = (Tom)dokument;
                    Console.WriteLine($" ISBN:{tom1.Isbn} Liczba stron:{tom1.LiczbaStron} Rok Wydania:{tom1.RokWydania} Tytul:{tom1.Tytul} Numer tomu:{tom1.NumerTomu} Liczba tomow:{tom1.LiczbaTomow} Autor:{tom1.Autor}");

                }
                else if (dokument is Czasopismo)
                {
                    Czasopismo czasopismo1 = (Czasopismo)dokument;
                    Console.WriteLine($" ISBN: {czasopismo1.Isbn} Liczba stron: {czasopismo1.LiczbaStron} Rok:{czasopismo1.RokWydania} Tytul:{czasopismo1.Tytul} Numer:{czasopismo1.Numer} Rodzaj:{czasopismo1.Rodzaj} ");
                }
                else
                {
                    Console.WriteLine($" ISBN:{dokument.Isbn} Liczba stron: {dokument.LiczbaStron} Rok:{dokument.RokWydania} Tytul{dokument.Tytul}");
                }

            }

            Tom tom4 = new Tom(3, 2, "Adam", "10", "Witam", 2001, 680);
            Tom tom5 = new Tom(2, 2, "Ewa", "11", "Jakis Tytul", 1300, 680);
            Tom tom6 = new Tom(2, 2, "Cos", "11", "Inny", 2012, 680);
            Tom tom7 = new Tom(2, 2, "Cos", "12", "Inny", 2012, 680);
            Ksiazka ksiazka4 = new Ksiazka("Alicja", "6", "Uwazaj", 2013, 476);
            try
            {
                dokuments.Dodaj(tom4);
                dokuments.Dodaj(tom5);
                dokuments.Dodaj(tom6);
                dokuments.Dodaj(tom7);
                dokuments.Dodaj(ksiazka4);
            }

            catch (DokumentException e)
            {
                ExceptionInfo.Wypisz(e);
            }
            catch (TomNumberException e)
            {
               
                ExceptionInfo.Wypisz(e);
            }
            catch (TomTitileException e)
            {
               
                ExceptionInfo.Wypisz(e);
            }
            catch (DataException e)
            {
                ExceptionInfo.Wypisz(e);
            }
            Console.ReadLine();
        }
    }
}
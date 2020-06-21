using lab4;
using lab4.klasy;
using lab4lib.interfejsy;
using lab4lib.klasy;
using lab4lib.klasy.miesozerne;
using lab4lib.klasy.roslinozerne;
using lab4lib.klasy.wszystkozerne;
using lab4lib.wyjatki;
using System;
using System.Collections.Generic;

namespace lab4app
{
    internal class Program
    {
        private static List<Istota> istoty = new List<Istota>();
        private static List<IRoslinozerne> roslinozerne = new List<IRoslinozerne>();
        private static List<IMiesozerne> miesozerne = new List<IMiesozerne>();

        private static void Main(string[] args)
        {

            try
            {
                Dodaj();
            }
                
           catch (PrzezroczystoscException e)
            {
                ExceptionInfo.Wypisz(e);
            }
            catch (SzybkoscException e)
            {
                ExceptionInfo.Wypisz(e);
            }

            Czlowiek czlowiek = new Czlowiek(100, 30, "Pawel", 150,
                      new List<Dom>
            {
                new Dom(123,552334),
                new Dom(1234,100000)
  },
                      new List<Samochod>
  {
                new Samochod("fiat",50000),
                new Samochod("ferrari",12334)
  });

            Czlowiek klon = (Czlowiek)czlowiek.Clone();
            Console.WriteLine(klon.Imie);

            Console.WriteLine(klon.IQ);
            czlowiek.Samochody.Add(new Samochod("BMW", 1500));
            
            Console.WriteLine("KLOOOOOOOON");
            foreach (var samochod in klon.Samochody)
            {
                Console.WriteLine(samochod);
            }

            Czlowiek czlowiek1 = new Czlowiek(100, 30, "Pawel", 150,
          new List<Dom>
{
                new Dom(120,300),
                new Dom(150,400)
},
          new List<Samochod>
{
                new Samochod("fiat",20000),
                new Samochod("skoda",1000)
});
            

            foreach (var dom in czlowiek.PrzegldajDomy(1200))
            {
                Console.WriteLine(dom);
            }

            foreach (var samochod in czlowiek.Samochody)
            {
                Console.WriteLine(samochod);
            }


            List<Czlowiek> czlowieki = new List<Czlowiek>();
            czlowieki.Add(czlowiek);
            czlowieki.Add(czlowiek1);
            czlowieki.Sort(new DomyComparer());
            Console.WriteLine("porownanie");

            switch(czlowiek.Compare(new SamochodComparer(), czlowiek1, czlowiek))
            {
                case 1:
                    break;
                    Console.WriteLine("Pierwszy ma wiecej samochodow");
                case -1:
                    Console.WriteLine("Drugi ma wiecej samochodow");
                    break;
                case 0:
                    Console.WriteLine("Maja tyle samo");
                    break;
            }
      

            foreach (var dom in czlowiek.PrzegldajDomy(1200))
            {
                Console.WriteLine(dom);
            }

            foreach (var samochod in czlowiek)
            {
                Console.WriteLine(samochod);
            }

            DoRoslinozernych();
            DoMiesozernych();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Karmienie wszystkich miesozercow i roslinozercow");
            Console.ForegroundColor = ConsoleColor.White;
            KarmienieDuzo();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Karmienie miesozercy");
            Console.ForegroundColor = ConsoleColor.White;
            KarmienieMiesozercy(miesozerne[0]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Karmienie roslinozercy");
            Console.ForegroundColor = ConsoleColor.White;
            KarmienieRoslinozercy(roslinozerne[0]); 
        }

        private static void Dodaj()
        {
         
            istoty.AddRange(new List<Istota>
            {
                new Rosiczka(10, "Magda", 12, Stan.Rosnie),
                new Tygrys(40, "Pawel", 20),
                new Krowa(20, "Jagoda", 30),
                new Duch(20, 60, "BUUUUU", "Marcin", 50),
                new Duch(20, 60, "AAAaaAaaAAA", "Kacperek", 50),
                new Zyrafa(10, "Aneta", 60),
                new Niedzwiedz(30, "Piotr", 30),
                new Roslina(10, "Krzak", 10, Stan.Rosnie)
            }

                );
      
        }

        private static void WypiszWszystko()
        {
            foreach (var item in istoty)
            {
                item.ToString();
            }
        }

        private static void DoRoslinozernych()
        {
            foreach (var item in istoty)
            {
                if (item is IRoslinozerne)
                {
                    roslinozerne.Add((IRoslinozerne)item);
                }
            }
        }

        private static void DoMiesozernych()
        {
            foreach (var item in istoty)
            {
                if (item is IMiesozerne)
                {
                    miesozerne.Add((IMiesozerne)item);
                }
            }
        }

        private static void KarmienieDuzo()
        {
            foreach (var item in roslinozerne)
            {
                item.ZnajdzPozywienie();
                item.ZjedzRosline();
            }
            foreach (var item in miesozerne)
            {
                item.ZnajdzPozywienie();
                item.ZjedzMieso();
            }
        }

        private static void KarmienieRoslinozercy(IRoslinozerne istota)
        {
            istota.ZnajdzPozywienie();
            istota.ZjedzRosline();
        }

        private static void KarmienieMiesozercy(IMiesozerne istota)
        {
            istota.ZnajdzPozywienie();
            istota.ZjedzMieso();
        }

 
    }
}
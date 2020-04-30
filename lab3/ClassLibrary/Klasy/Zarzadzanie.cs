using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Wyjatki;

namespace ClassLibrary
{
    public class Zarzadzanie
    {
        
        public List<Dokument> dokumenty { get; set; }

        public Zarzadzanie()
        {
            dokumenty = new List<Dokument>();
        }

        public void Dodaj(Dokument dokument)
        {
            
                var check = dokumenty.Find(i => i.Isbn.Equals(dokument.Isbn));
                if (check != null)
                {
                    
                    throw new DokumentException("Dokument jest juz w bazie");
                }
                else if (dokument.RokWydania < 1450)
                {
                    throw new DataException($"No co Ty no wez zobacz ze wtedy to sie drukowac nawet nie dalo opamietaj sie wpisales {dokument.RokWydania} a powininna byc wieksza niz 1450");
                }
                else if (dokument.GetType() == typeof(Tom))
                {

                    Tom tom = (Tom)dokument;


                    foreach (var dok in dokumenty)
                    {
                        if (dok.GetType() == typeof(Tom))
                        {
                            Tom dokT = (Tom)dok;
                            if (dokT.Tytul == tom.Tytul && dokT.NumerTomu == tom.NumerTomu)
                            {
                                
                                throw new TomTitileException("No ale tutaj to juz mamy taka nie chemy drugiej");
                            }
                        }
                    }

                    /*var tomy = (List<Tom>)dokumenty.Where(i => i.GetType() == typeof(Tom));
                      if (tomy.Exists(i => i.Tytul.Equals(tom.Tytul) && i.NumerTomu.Equals(tom.NumerTomu)))
                      {
                          ExceptionInfo.Wypisz(new TomTitileException("No ale tutaj to juz mamy taka nie chemy drugiej"));
                          throw new TomTitileException("No ale tutaj to juz mamy taka nie chemy drugiej");

                  }
                    */
                    if (tom.NumerTomu > tom.LiczbaTomow)
                    {
                        
                        throw new TomNumberException($"Cos nakliklaes wiekszy numer tomu niz jest tomow numer tomu {tom.NumerTomu} Liczba Tomow {tom.LiczbaTomow}");
                    }

                }

                dokumenty.Add(dokument);
            
       
           

        }

        public void UsunPoIsbn(String Isbn)
        {
            dokumenty.Remove(dokumenty.Find(i => i.Isbn == Isbn));
        }

        public Dokument PokazDokument(String Isbn)
        {
            return dokumenty.Find(i => i.Isbn == Isbn);
        }

        public List<Dokument> PobierzDokumenty(String fraza)
        {
            return dokumenty.FindAll(i => i.Tytul.Contains(fraza));
        }

        public List<Czasopismo> PobierzCzasopisma(Czestotliwosc nazwa)
        {
            return dokumenty.FindAll(i => i is Czasopismo && ((Czasopismo)i).Rodzaj == nazwa).Cast<Czasopismo>().ToList();
        }

        public List<Tom> PobierzTomy(string Tytul)
        {
            return dokumenty.FindAll(i => i is Tom && i.Tytul.Equals(Tytul)).Cast<Tom>().ToList();
        }
    }
} 
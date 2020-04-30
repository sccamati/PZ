using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.klasy
{
    public class Samochod
    {

        public String Model { get; set; }
        public int Cena { get; set; }

        public Samochod(string model, int cena)
        {
            Model = model;
            Cena = cena;
        }

        public override string ToString()
        {
            return $"Model: {Model} Cena: {Cena}"; 
        }
    }
}

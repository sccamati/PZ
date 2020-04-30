using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Programista : Pracownik
    {
		private int liczbaWykorzystywanychTechnologii;

		public int Liczba_Wykorzystywanych_Technologii
		{
			get { return liczbaWykorzystywanychTechnologii; }
			set { liczbaWykorzystywanychTechnologii = value; }
		}

		public Programista(int liczba_Wykorzystywanych_Technologii, int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, decimal pensja) : base( numerIdentyfikacyjny,  imie,  nazwisko,  wiek,  pensja)
		{
			this.Liczba_Wykorzystywanych_Technologii = liczba_Wykorzystywanych_Technologii;
		}

		public Programista()
		{
		}

		public override void Wyswietl()
		{
			base.Wyswietl();
			Console.Write(" liczba wykorzystanych technologii " + Liczba_Wykorzystywanych_Technologii);
		}

		public override void ZwiekszPensje(decimal pieniadze)
		{
			base.ZwiekszPensje(pieniadze);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6Lib
{
    public class Pracownik
    {
		private int id_;

		public int ID
		{
			get { return id_; }
			set { id_ = value; }
		}

		private String imie_;

		public String Imie
		{
			get { return imie_; }
			set { imie_ = value; }
		}

		private String nazwisko_;

		public String Nazwisko
		{
			get { return nazwisko_; }
			set { nazwisko_ = value; }
		}

		private int staz_;

		public int Staz
		{
			get { return staz_; }
			set { staz_ = value; }
		}

		private int liczbaSprzedazy_;

		public int LiczbaSprzedazy
		{
			get { return liczbaSprzedazy_; }
			set { liczbaSprzedazy_ = value; }
		}

		private decimal pensja_;

		public decimal Pensja
		{
			get { return pensja_; }
			set { pensja_ = value; }
		}

		public Pracownik(int iD, string imie, string nazwisko, int staz, int liczbaSprzedazy, int pensja)
		{
			ID = iD;
			Imie = imie;
			Nazwisko = nazwisko;
			Staz = staz;
			LiczbaSprzedazy = liczbaSprzedazy;
			Pensja = pensja;
		}

		public Pracownik()
		{
		}

		public override string ToString()
		{
			return $"ID: {ID} Imie: {Imie} Naziwsko: {Nazwisko} Liczba srzedazy: {LiczbaSprzedazy} Staz: {Staz} Pensja: {Pensja}";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6Lib
{
	public delegate String DelegateShow(Pracownik pracownik);
	public delegate void PracownikDelegat(Pracownik pracownik);
	public delegate bool DelegateBool(Pracownik pracownik);
	public delegate bool DelegateSort(Pracownik prac1, Pracownik prac2);
	public class Firma
    {
		private List<Pracownik> pracownicy;
		public event PracownikDelegat OnAdded;
		public event PracownikDelegat OnDelete;




		public Firma()
		{
			pracownicy = new List<Pracownik>();
		}
		public void Add(Pracownik pracownik)
		{
			pracownicy.Add(pracownik);
	
			OnAdded?.Invoke(pracownik);
			
		}

		public void EmployeeInfo(DelegateShow delegat)
		{

			foreach (var item in pracownicy)
			{
				Console.WriteLine(delegat(item));
			}
			
		}

		public List<Pracownik> SearchEmployees(DelegateBool delegat)
		{
			List<Pracownik> list = new List<Pracownik>();
			foreach (var item in pracownicy)
			{
				if (delegat(item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		public void  Sort(DelegateSort delegat)
		{
			
			for (int j = 0; j < pracownicy.Count - 1; j++)
			{
				for (int i = 0; i < pracownicy.Count - j - 1; i++)
				{
					if(delegat(pracownicy[i], pracownicy[i + 1]))
					{
						
						Pracownik prac = pracownicy[i];
						pracownicy[i] = pracownicy[i + 1];
						pracownicy[i + 1] = prac;
					}
				}
			}
		}


		public void Delete(int id)
		{
			var pracownik = pracownicy.Find(x => x.ID.Equals(id));
			pracownicy.Remove(pracownik);
			
				OnDelete?.Invoke(pracownik);
			
			
		}

		public void DelegateMethod(PracownikDelegat pracownikDelegat)
		{
			foreach (var item in pracownicy)
			{
				pracownikDelegat(item);
			}
		}

		public Pracownik FindByID(int id) => pracownicy.Find(x => x.ID.Equals(id));
		

		public List<Pracownik> FindByPhrase(String phrase) => pracownicy.FindAll(x => x.Imie.Contains(phrase) || x.Nazwisko.Contains(phrase));
		

		public List<Pracownik> FindBySales() => pracownicy.FindAll(x => x.LiczbaSprzedazy >= 10 && x.LiczbaSprzedazy< 200);
		

		public List<Pracownik> Find3Wokers() => pracownicy.OrderByDescending(x => x.Staz).Take(3).ToList();
		
		
	}
}

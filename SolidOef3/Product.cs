using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOef3
{
	class Product
	{
		public string Naam { get; set; }
		public Kleuren Kleur { get; set; }
		public int Grootte { get; set; }
		public Product()
		{

		}
		public Product(string naam,Kleuren kleur,int grootte)
		{
			Naam = naam;
			Kleur = kleur;
			Grootte = grootte;
		}
		public override string ToString()
		{
			return $"Naam: {Naam} Kleur: {Kleur} Grootte: {Grootte}";
		}
	}
}

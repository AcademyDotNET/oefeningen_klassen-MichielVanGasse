using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
	class Driehoek
	{
		private double basis;
		private double hoogte;

		public double Basis
		{
			get
			{
				return basis;
			}
			set
			{
				if (value < 1)
				{
					basis = 1;
				}
				else
				{
					basis = value;
				}
			}
		}
		public double Hoogte
		{
			get
			{
				return hoogte;
			}
			set
			{
				if (value < 1)
				{
					hoogte = 1;
				}
				else
				{
					hoogte = value;
				}
			}
		}

		public void ToonOppervlakte()
		{
			Console.WriteLine($"Oppervlakte driehoek is {(hoogte*basis)/2}");
		}
	}
}


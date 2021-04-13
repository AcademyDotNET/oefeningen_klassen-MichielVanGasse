using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
	class Pizza
	{
		private string toppings = "bevat beschrijving van wat er op ligt, bv.ananas, pepperoni, etc.";
		private int diameter = 0;
		private double price = 0;

		public string Toppings
		{
			get
			{
				return toppings;
			}
			set
			{
				if (value != null)
				{
					toppings = value;
				}
				else
				{
					toppings = "ananas, pepperoni";
				}
			}
		}

		public int Diameter
		{
			get
			{
				return diameter;
			}
			set
			{
				if (value >= 0)
				{
					diameter = value;
				}
				else
				{
					diameter = 0;
				}
			}
		}

		public double Price
		{
			get
			{
				return price;
			}
			set
			{
				if(value >= 0)
				{
					price = value;
				}
				else
				{
					price = 0;
				}
				
			}
		}
	}
}

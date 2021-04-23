using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
	class CoffeeTableBook : Book
	{
		public override double Price
		{
			get { return price; }
			set
			{
				if (value >= 35 && value <= 100)
				{
					price = value;
				}
				else if (value < 35)
				{
					price = 35;
				}
				else
				{
					price = 100;
				}
			}
		}
		
	}
}

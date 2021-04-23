using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
	class TextBook : Book
	{
		public int GradeLevel { get; set; }
		public override double Price
		{
			get { return price; }
			set
			{
				if (value >= 20 && value <= 80)
				{
					price = value;
				}
				else if (value < 20)
				{
					price = 20;
				}
				else
				{
					price = 80;
				}
			}
		}

	}
}

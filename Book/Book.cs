using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
	class Book
	{
		public int ISBN { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }

		protected double price;

		public virtual double Price
		{
			get { return price; }
			set { price = value; }
		}
		public static Book TelOp(Book boek1,Book boek2)
		{
			Book omnibus = new Book();
			omnibus.Title = $"Omnibus van {boek1.Author},{boek2.Author}";
			omnibus.Author = $"{boek1.Author},{boek2.Author}";
			omnibus.Price = (boek1.Price + boek2.Price) / 2.0;
			return omnibus;
		}
		public override string ToString()
		{
			return $"{Title} - {Author} ({ISBN}) {Price}";
		}

		public override bool Equals(object obj)
		{
			if((obj == null) || obj.GetType().BaseType != typeof(Book) && obj.GetType() != typeof(Book))
			{
				return false;
			}
			else
			{ 
				Book book = (Book)obj;
				if(book.ISBN == ISBN)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
	}
}


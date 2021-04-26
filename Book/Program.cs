using System;

namespace Book
{
	class Program
	{
		static void Main(string[] args)
		{
			Book book = new Book();
			CoffeeTableBook coffeeTableBook = new CoffeeTableBook();
			TextBook textBook = new TextBook();
			Test test = new Test();

			test.ISBN = 1;

			book.Price = 30;
			coffeeTableBook.Price = 10;
			textBook.Price = 30;

			book.ISBN = 1;
			coffeeTableBook.ISBN = 2;
			textBook.ISBN = 1;

			book.Author = "jos";
			coffeeTableBook.Author = "fien";
			textBook.Author = "jos";

			book.Title = "how to program";
			coffeeTableBook.Title = "how to sing";
			textBook.Title = "how to program";

			Book testbook = Book.TelOp(coffeeTableBook, book);

			Console.WriteLine($"{testbook.ISBN} and {testbook} are equal");

			if (book.Equals(textBook))
			{
				Console.WriteLine($"{textBook} and {book} are equal");
			}
			else
			{
				Console.WriteLine($"{textBook} and {book} are not equal");
			}
		}
	}
}

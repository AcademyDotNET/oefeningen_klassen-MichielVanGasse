using System;

namespace PizzaTime
{
	class Program
	{
		static void Main(string[] args)
		{
			Pizza pepperonyPizza = new Pizza();
			Pizza mozerellaPizza = new Pizza();

			pepperonyPizza.Diameter = 5;
			mozerellaPizza.Diameter = 2;
			pepperonyPizza.Price = 6;
			mozerellaPizza.Price = 4;
			pepperonyPizza.Toppings = "cheese, meat and more meat";
			mozerellaPizza.Toppings = "cheese";

		}
	}
}

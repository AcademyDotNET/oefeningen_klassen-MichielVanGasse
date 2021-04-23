using System;

namespace PokemonExtra
{
	class Program
	{
		static void Main(string[] args)
		{
			Pokémon pokemon;
			pokemon = Pokémon.GeneratorPokemon();
			Console.WriteLine(pokemon);
		}
	}
}

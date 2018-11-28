using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountASCII
{
	class Program
	{
		static void Main(string[] args)
		{
			string input;

			char[] characters;

			int Sum = 0;

			Console.Write("Introduce la cadena a sumar: ");
			input = Console.ReadLine();

			characters = new char[input.Length];

			for (int i = 0; i < input.Length; i++)
			{
				characters[i] = input[i];
			}

			for (int i = 0; i < characters.Length; i++)
			{
				Sum = Sum + characters[i];
				if (Sum >= 255)
				{
					Sum = Sum - 255;
				}
			}
			
			Console.WriteLine($"La suma de los valores ASCII es {Sum:D3}");

			Console.ReadKey();


		}
	}
}

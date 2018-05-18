using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriter_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "StreamWriter_Example";

			string filePathName = "c:\\users\\msunk\\documents\\visual studio 2017\\CoderGirlWinter2018\\FileHandling\\StreamWriter_Example\\cSharpFile.txt";

			// Write string data into a text file using StreamWriter Class. 
			/*
			using (StreamWriter writer = new StreamWriter(filePathName))
			{
				writer.Write("Hello");
				writer.WriteLine("Hello StreamWriter Class");
				writer.WriteLine("How are you!");
			}
			Console.WriteLine("Data String Saved Successfully using StreamWriter !");
			Console.ReadKey();
			*/

			// save variable data in a file using StreamWriter Class.
			/*
			int a, b, result;
			a = 5;
			b = 10;
			result = a + b;

			using (StreamWriter writer = new StreamWriter(filePathName))
			{
				writer.Write("Sum of {0} + {1} = {2}", a, b, result);
			}
			Console.WriteLine("Saved - Sum of {0} + {1} = {2}", a, b, result);
			Console.ReadKey();
			*/

		}
	}
}

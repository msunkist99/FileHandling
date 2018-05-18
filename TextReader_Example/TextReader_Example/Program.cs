using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextReader_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "TextReader_Example";

			string filePathName = "c:\\users\\msunk\\documents\\visual studio 2017\\CoderGirlWinter2018\\FileHandling\\TextReader_Example\\cSharpFile.txt";

			// TextReader Class represents a reader that can read a sequential series of Characters. 
			// It is abstract class that means you cannot instantiate it. 
			// After finishing reading or writing file you must dispose or clean memory directly or indirectly. 
			// To directly dispose, call Dispose Method in try/catch block and for indirectly disposal write code inside using block.

			//Read One Line
			using (TextReader tr = File.OpenText(filePathName))
			{
				Console.WriteLine(tr.ReadLine());
			}

			Console.WriteLine();

			//Read 4 Characters
			using (TextReader tr = File.OpenText(filePathName))
			{
				char[] ch = new char[4];
				tr.ReadBlock(ch, 0, 4);
				Console.WriteLine(ch);
			}

			Console.WriteLine();

			//Read full file
			using (TextReader tr = File.OpenText(filePathName))
			{
				Console.WriteLine(tr.ReadToEnd());
			}
			Console.ReadKey();
		}
	}
}

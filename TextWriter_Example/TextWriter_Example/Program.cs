using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWriter_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "TextWriter_Example";

			string filePathName = "c:\\users\\msunk\\documents\\visual studio 2017\\CoderGirlWinter2018\\FileHandling\\TextWriter_Example\\cSharpFile.txt";

			// The TextWriter class represents a writer that can write sequential series of text characters. 
			// You can use this class to write text in a file. 
			// It is an abstract base class of StreamWriter and StringWriter, which write characters to streams and string respectively.

			using (TextWriter writer = File.CreateText(filePathName))
			{
				writer.WriteLine("Hello TextWriter!");
				writer.WriteLine("File Handling Tutorial");
			}
			Console.WriteLine("Entry stored successfull!");
			Console.ReadKey();
		}
	}
}

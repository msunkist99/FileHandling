using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringReader_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "StringReader_Example";

			// StringReader class implements TextReader class that reads string from string. 
			// It enables you to read a string synchronously or asynchronously. 
			// You can read a character with Read() method and read a line with ReadLine() method.


			string stringText = @"You are reading
this article at
completecsharptutorial.com";

			using (StringReader stringReader = new StringReader(stringText))
			{
				int count = 0;
				string line;
				while ((line = stringReader.ReadLine()) != null)
				{
					count++;
					Console.WriteLine("Line {0}: {1}", count, line);
				}
			}
			Console.ReadKey();
		}
	}
}

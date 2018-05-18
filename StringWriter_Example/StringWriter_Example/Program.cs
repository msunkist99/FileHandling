using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringWriter_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "StringWriter_Example";

			// StringWriter class is derived from TextWriter class and it is mainly used to manipulate string rather than files.
			// StringWriter enables you to write to a string synchronously or asynchronously. 
			// You can write a character with Write(Char) or WriteAsync(Char) method and writer string with Write(String) or WriterAsync(String) method. 
			// The text or information written by StringWriter class is stored inside a StringBuilder.

			// Note: StringWriter is not for writing files on local disk. It is used for manipulate string and it saves information in StringBuilder.

			string stringText = "Hello. This is Line 1 \n Hello. This is Line 2 \nHello This is Line 3";

			StringBuilder stringBuilder = new StringBuilder();

			//Writing string into StringBuilder
			StringWriter stringWriter = new StringWriter(stringBuilder);

			//Store Data on StringBuilder
			stringWriter.WriteLine(stringText);
			stringWriter.Flush();
			stringWriter.Close();

			//Read Entry
			StringReader stringReader = new StringReader(stringBuilder.ToString());
			//Check to End of File
			while (stringReader.Peek() > -1)
			{
				Console.WriteLine(stringReader.ReadLine());
			}

			Console.ReadLine();
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryWriter_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "BinaryWriter_Example";

			string filePathName = "c:\\users\\msunk\\documents\\visual studio 2017\\CoderGirlWinter2018\\FileHandling\\BinaryWriter_Example\\cSharpFileBinaryFile.bin";

			// BinaryWriter class makes easy to write Binary File in C#. 

			using (BinaryWriter writer = new BinaryWriter(File.Open(filePathName, FileMode.Create)))
			{
				//Writting Error Log
				writer.Write("0x80234400");
				writer.Write("Windows Explorer Has Stopped Working");
				writer.Write(true);
			}
			Console.WriteLine("Binary File Created!");
			Console.ReadKey();

			// When you open the file cSharpFileBinaryFile.bin in visual studio the file may look like this. 
			// However, it is hard to understand but it is more efficient and machine level representation of data. 
			// This is because the data is not encoded in text file. 
			// Don’t worry when you read your data using BinaryReader Class you will get exact data that you saved.
		}
	}
}

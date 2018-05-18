using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "StreamReader_Example";

			string filePathName = "c:\\users\\msunk\\documents\\visual studio 2017\\CoderGirlWinter2018\\FileHandling\\StreamReader_Example\\cSharpFile.txt";

			// StreamReader class allows you to read text files easily. 
			// Its implementation is easy and it is widely popular among the programmer. 
			// However, there are dozens of way to read text file in C# file handling but StreamReader Class is more popular in list.

			//Writer data to text file
			using (StreamWriter writer = new StreamWriter(filePathName))
			{
				writer.WriteLine("This tutorial explains how to use StreamReader Class in C# Programming");
				writer.WriteLine("Good Luck!");
			}

			//Reading text file using StreamReader Class            
			using (StreamReader reader = new StreamReader(filePathName))
			{
				Console.WriteLine(reader.ReadToEnd());
			}
			Console.ReadKey();
		}
	}
}

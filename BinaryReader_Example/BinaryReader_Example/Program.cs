using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryReader_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "BinaryReader_Example";

			string filePathName = "c:\\users\\msunk\\documents\\visual studio 2017\\CoderGirlWinter2018\\FileHandling\\BinaryReader_Example\\cSharpFileBinaryFile.bin";

			//  If you have bin file stored in your PC and you want to read them then BinaryReader may help you lot. 
			//  BinaryReader class is used to reading binary files. 
			//  A binary file stored data in different layout that is more efficient for machine but not convenient for human. 
			//  BinaryReader makes this job simpler and show you exact data stored in bin file.

			WriteBinaryFile(filePathName);
			ReadBinaryFile(filePathName);
			Console.ReadKey();
		}

		static void WriteBinaryFile(string filePathName)
		{
			using (BinaryWriter writer = new BinaryWriter(File.Open(filePathName, FileMode.Create)))
			{
				//Writting Error Log
				writer.Write("0x80234400");
				writer.Write("Windows Explorer Has Stopped Working");
				writer.Write(true);
			}
		}

		static void ReadBinaryFile(string filePathName)
		{
			using (BinaryReader reader = new BinaryReader(File.Open(filePathName, FileMode.Open)))
			{
				Console.WriteLine("Error Code : " + reader.ReadString());
				Console.WriteLine("Message : " + reader.ReadString());
				Console.WriteLine("Restart Explorer : " + reader.ReadBoolean());
			}
		}
	}
}

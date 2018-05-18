using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "FileStream_Example";

			string filePathName = "c:\\users\\msunk\\documents\\visual studio 2017\\CoderGirlWinter2018\\FileHandling\\FileStream_Example\\cSharpFile.txt";

			// FileStream Class is used to perform the basic operation of 
			// reading and writing operating system files. 
			// FileStream class helps in reading from, writing and closing files.

			/*
			FileStream fs = new FileStream(filePathName, FileMode.Create);

			fs.Close();
			Console.Write("File has been created and the Path is D:\\csharpfile.txt");
			Console.ReadKey();
			*/

			/*
			// A text strin is Encodedinto bytes and kept into byte[] variable bdata array and finally using Write() method of FileStream stored string into file.
			FileStream fs = new FileStream(filePathName, FileMode.Append);

			byte[] byteDataArray = Encoding.Default.GetBytes("Hello File Handling!  From the byteDataArray");
			fs.Write(byteDataArray, 0, byteDataArray.Length);
			fs.Close();
			Console.WriteLine("Successfully saved file with data in byteDataArray : Hello File Handling!");
			Console.ReadKey();
			*/


			// opened the file with Read permission and use StreamReader class to read file.
			string stringData;

			FileStream fsSource = new FileStream(filePathName, FileMode.Open, FileAccess.Read);
			using (StreamReader sr = new StreamReader(fsSource))
			{
				stringData = sr.ReadToEnd();
			}
			Console.WriteLine(stringData);
			Console.ReadLine();
		}
	}
}

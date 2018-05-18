using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInfo_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "FileInfo_Example";

			// FileInfo class in c# is used for manipulating file as creating, deleting, removing, copying, opening and getting information. 
			//It provides properties and instance methods that makes file manipulation easy.

			string filePath = "c:\\users\\msunk\\documents\\visual studio 2017\\CoderGirlWinter2018\\FileHandling\\fileinfo.txt";

			FileInfo fileInfo = new FileInfo(filePath);
			//Create File
			using (StreamWriter streamWriter = fileInfo.CreateText())
			{
				streamWriter.WriteLine("Hello FileInfo");
			}

			//Display File Info            
			Console.WriteLine("File Create on : " + fileInfo.CreationTime);
			Console.WriteLine("Directory Name : " + fileInfo.DirectoryName);
			Console.WriteLine("Full Name of File : " + fileInfo.FullName);
			Console.WriteLine("File is Last Accessed on : " + fileInfo.LastAccessTime);

			//Deleting File
			Console.WriteLine("Press small y for delete this file");
			try
			{
				char ch = Convert.ToChar(Console.ReadLine());
				if (ch == 'y')
				{
					if (fileInfo.Exists)
					{
						fileInfo.Delete();
						Console.WriteLine(filePath + " Deleted Successfully");
					}
					else
					{
						Console.WriteLine("File doesn't exist");
					}
				}
			}
			catch
			{
				Console.WriteLine("Press Enter to Exit");
			}
			Console.ReadKey();
		}
	}
}

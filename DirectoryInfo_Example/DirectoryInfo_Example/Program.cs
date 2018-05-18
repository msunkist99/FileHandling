using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryInfo_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "DirectoryInfo_Example";

			// DirectoryInfo class allows you to work with directory and its make directory manipulation as create, delete, info etc easy.
			// It exposes instance methods for creating, moving, enumerating through directories and subdirectories.

			string filePath = "c:\\users\\msunk\\documents\\visual studio 2017\\CoderGirlWinter2018\\FileHandling\\DirectoryInfo_Example\\TEST";

			DirectoryInfo direcoryInfo = new DirectoryInfo(filePath);
			try
			{
				if (direcoryInfo.Exists)
				{
					Console.WriteLine("{0} Directory is already exists", filePath);
					Console.WriteLine("Directory Name : " + direcoryInfo.Name);
					Console.WriteLine("Path : " + direcoryInfo.FullName);
					Console.WriteLine("Directory is created on : " + direcoryInfo.CreationTime);
					Console.WriteLine("Directory is Last Accessed on " + direcoryInfo.LastAccessTime);
				}
				else
				{
					direcoryInfo.Create();
					Console.WriteLine(filePath + " - " + "Directory is created successfully");
				}
				//Delete this directory
				Console.WriteLine("If you want to delete this directory press small y. Press any key to exit.");
				try
				{
					char ch = Convert.ToChar(Console.ReadLine());
					if (ch == 'y')
					{
						if (direcoryInfo.Exists)
						{
							direcoryInfo.Delete();
							Console.WriteLine(filePath + "Directory Deleted");
						}
						else
						{
							Console.WriteLine(filePath + "Directory Not Exists");
						}
					}
				}
				catch
				{
					Console.WriteLine("Press Enter to Exit");
				}
				Console.ReadKey();
			}
			catch (DirectoryNotFoundException d)
			{
				Console.WriteLine("Exception raised : " + d.Message);
			}
		}
	}
}

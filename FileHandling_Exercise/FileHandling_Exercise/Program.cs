using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling_Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "FileHandling_Exercise";

			string filePath = "c:\\users\\msunk\\documents\\visual studio 2017\\CoderGirlWinter2018\\FileHandling\\FileHandling_Exercise\\Student";

			DirectoryInfo directoryInfo = new DirectoryInfo(filePath);

			try
			{
				if (directoryInfo.Exists)
				{
					Console.WriteLine("{0} Directory is already EXISTS", filePath);
					Console.WriteLine("Directory Name : " + directoryInfo.Name);
					Console.WriteLine("Path : " + directoryInfo.FullName);
					Console.WriteLine("Directory is created on : " + directoryInfo.CreationTime);
					Console.WriteLine("Directory is Last Accessed on " + directoryInfo.LastAccessTime);
				}
				else
				{
					directoryInfo.Create();
					Console.WriteLine(filePath + " - " + "Directory is CREATED successfully" + filePath);
					Console.WriteLine("Directory Name : " + directoryInfo.Name);
					Console.WriteLine("Path : " + directoryInfo.FullName);
					Console.WriteLine("Directory is created on : " + directoryInfo.CreationTime);
					Console.WriteLine("Directory is Last Accessed on " + directoryInfo.LastAccessTime);

				}
				//Delete this directory
				Console.WriteLine("If you want to delete this directory enter Yes. Press any key to exit.");
				try
				{
					string input = Console.ReadLine();
					if (input == "Yes")
					{
						if (directoryInfo.Exists)
						{
							directoryInfo.Delete();
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
				}
			}
			catch (DirectoryNotFoundException d)
			{
				Console.WriteLine("Exception raised : " + d.Message);
			}

			Console.WriteLine("Enter student file name - ");
			string studentName = Console.ReadLine();
			string filePathName = filePath + "\\" + studentName + ".txt";

			if (File.Exists(filePathName))
			{
				Console.WriteLine("File already exists - " + filePathName);
			}
			else
			{
				using (StreamWriter streamWriter = File.CreateText(filePathName))
				{
					Console.Write("Enter your name - ");
					streamWriter.WriteLine("Student name:  " + Console.ReadLine());

					Console.Write("Enter your age - ");
					streamWriter.WriteLine("Age:  " + Console.ReadLine());

					Console.Write("Enter your city - ");
					streamWriter.WriteLine("City:  " + Console.ReadLine());

					Console.Write("Enter your subject - ");
					streamWriter.WriteLine("Subject:  " + Console.ReadLine());

					Console.WriteLine("Information save to - " + filePathName);
				}
			}

			using (
				StreamReader streamReader = new StreamReader(filePathName))
			{
				string textLine = null;
				while ((textLine = streamReader.ReadLine()) != null)
				{
					Console.WriteLine(textLine);
				}
			}

			Console.ReadLine();
		}
	}
}

		
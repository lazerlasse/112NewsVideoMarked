using _112NewsVideoMarked.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace _112NewsVideoMarked.Utillities
{
	public class GenerateThumbnailFromVideo
	{
		public static List<Image> GenerateThumbs(string filePath, string serverPath, int id, string physicalPath)
		{
			// Create a list for generated image...
			List<Image> images = new List<Image>();

			// Check if running OS are Windows or Linux...
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
			{
				GenerateThumbLinux(filePath, serverPath);
			}

			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				GenerateThumbWindows(filePath, serverPath);
			}

			// IEnumerable the generate files and add then in the database...
			IEnumerable<string> files = Directory.EnumerateFiles(serverPath).Where(f => f.Contains(".jpeg"));

			// Generate list of images to save in database...
			foreach (var fileContent in files)
			{
				Image image = new Image
				{
					ImageName = Path.GetFileNameWithoutExtension(fileContent),
					ImagePath = physicalPath + Path.GetFileName(fileContent),
					CaseContentID = id
				};

				images.Add(image);
			}

			return images;
		}

		private static void GenerateThumbWindows(string file, string imagePath)
		{

			string processArgs = "-ss 00:00:03 -i " + file + " -vf fps=1/15 -f image2 -vframes 8 " + Path.Combine(imagePath, "foo-%03d.jpeg");

			// Create new instance of the system process and run the command line in ffmpeg.exe (Windows Only)
			Process winProcess = new Process()
			{
				// Create startinformation for the process to run...
				StartInfo = new ProcessStartInfo()
				{
					CreateNoWindow = false,
					FileName = Path.Combine(Directory.GetCurrentDirectory(), "ffmpeg-win64-2019", "bin", "ffmpeg.exe"), // Path to the ffmpeg
					WindowStyle = ProcessWindowStyle.Normal,
					Arguments = processArgs
				}
			};

			// Try run the commandline process or throw an exeption...
			try
			{
				winProcess.Start();
				winProcess.WaitForExit(300000); // wait for exit 10000 miliseconds
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private static void GenerateThumbLinux(string file, string imagePath)
		{
			string processArgs = "ffmpeg -ss 00:00:03 -i " + file + " -vf fps=1/15 -f image2 -vframes 8 " + Path.Combine(imagePath, "foo-%03d.jpeg");

			Process linuxProcess = new Process()
			{
				// Create startinformation for the process to run...
				StartInfo = new ProcessStartInfo()
				{
					CreateNoWindow = false,
					FileName = "/bin/bash",
					WindowStyle = ProcessWindowStyle.Normal,
					Arguments = processArgs
				}
			};

			// Try run the commandline process or throw an exeption...
			try
			{
				linuxProcess.Start();
				linuxProcess.WaitForExit(300000); // wait for exit 10000 miliseconds
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}

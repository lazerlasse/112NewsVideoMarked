using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _112NewsVideoMarked.Data
{
	public class MediaFileHandler
	{
		public static bool DeleteMediaFile(string path)
		{
			if (path == null)
			{
				return false;
			}

			// Get the physical path for the file to delete...
			var fileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"));
			var filePath = fileProvider.GetFileInfo(path);

			// Try deleting the file...
			try
			{
				if (filePath.Exists)
				{
					File.Delete(filePath.PhysicalPath);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}

			return true;
		}

		public static void DeleteMediaFolder(int id)
		{
			// Create a path string for the folder to delete...
			string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Cases", id.ToString());

			try
			{
				// Check directory exist...
				if (Directory.Exists(deletePath))
				{
					// Delete the folder...
					Directory.Delete(deletePath);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}

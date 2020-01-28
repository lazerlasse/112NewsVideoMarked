using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _112NewsVideoMarked.Data
{
	public class SaveUpload
	{
		public string FullFilePath { get; private set; }
		public string FileExtension { get; private set; }
		public string CaseContentFolder { get; private set; }


		public async Task<string> SaveUploadedFile(IFormFile file, int caseID)
		{
			// Create needed path for the case and set the extension varible...
			CaseContentFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Cases", caseID.ToString());
			FullFilePath = Path.Combine(CaseContentFolder, file.FileName);
			FileExtension = Path.GetExtension(FullFilePath);

			// Check if folder for files exist else create it...
			Directory.CreateDirectory(CaseContentFolder);

			// Save file to the case media folder...
			try
			{
				using (var fileStream = new FileStream(FullFilePath, FileMode.Create))
				{
					await file.CopyToAsync(fileStream);
				}
			}
			catch (Exception ex)
			{
				return "Der opstod en fejl: " + ex.Message;
			}

			return null;
		}
	}
}
